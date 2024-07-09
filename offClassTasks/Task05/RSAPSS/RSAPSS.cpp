#include <openssl/evp.h>
#include <openssl/pem.h>
#include <openssl/err.h>
#include <openssl/sha.h>
#include <openssl/rsa.h>
#include <openssl/rand.h>

#include <fstream>
#include <vector>
#include <iostream>
#include <string>
#include <iterator>
#include <chrono>
using namespace std;

bool GenerateKeys(const char *format, const char *privateKeyFile, const char *publicKeyFile, const int keysize)
{
    OpenSSL_add_all_algorithms();
    ERR_load_crypto_strings();

    string strFormat(format);
    RSA *rsa = RSA_new();
    BIGNUM *bne = BN_new();
    unsigned long e = RSA_F4;

    if (!BN_set_word(bne, e))
    {
        cerr << "Failed to initialize RSA key generation." << endl;
        return false;
    }

    if (!RSA_generate_key_ex(rsa, keysize, bne, NULL))
    {
        cerr << "Failed to generate RSA key pair." << endl;
        RSA_free(rsa);
        BN_free(bne);
        return false;
    }

    FILE *privateFile = fopen(privateKeyFile, "wb");
    if (!privateFile)
    {
        cerr << "Failed to open private key file." << endl;
        RSA_free(rsa);
        BN_free(bne);
        return false;
    }

    FILE *publicFile = fopen(publicKeyFile, "wb");
    if (!publicFile)
    {
        cerr << "Failed to open public key file." << endl;
        fclose(privateFile);
        RSA_free(rsa);
        BN_free(bne);
        return false;
    }

    if (strFormat == "BER")
    {
        if (!i2d_RSAPrivateKey_fp(privateFile, rsa))
        {
            cerr << "Failed to write BER format private key." << endl;
            fclose(privateFile);
            fclose(publicFile);
            RSA_free(rsa);
            BN_free(bne);
            return false;
        }

        if (!i2d_RSAPublicKey_fp(publicFile, rsa))
        {
            cerr << "Failed to write BER format public key." << endl;
            fclose(privateFile);
            fclose(publicFile);
            RSA_free(rsa);
            BN_free(bne);
            return false;
        }
    }
    else if (strFormat == "PEM")
    {
        if (!PEM_write_RSAPrivateKey(privateFile, rsa, NULL, NULL, 0, NULL, NULL))
        {
            cerr << "Failed to write PEM format private key." << endl;
            fclose(privateFile);
            fclose(publicFile);
            RSA_free(rsa);
            BN_free(bne);
            return false;
        }

        if (!PEM_write_RSA_PUBKEY(publicFile, rsa))
        {
            cerr << "Failed to write PEM format public key." << endl;
            fclose(privateFile);
            fclose(publicFile);
            RSA_free(rsa);
            BN_free(bne);
            return false;
        }
    }
    else
    {
        cerr << "Unknown format specified." << endl;
        fclose(privateFile);
        fclose(publicFile);
        RSA_free(rsa);
        BN_free(bne);
        return false;
    }

    fclose(privateFile);
    fclose(publicFile);
    RSA_free(rsa);
    BN_free(bne);
    return true;
}

int sign(const char *privateKeyFile, const char *filename, const char *signFile)
{
    OpenSSL_add_all_algorithms();
    ERR_load_crypto_strings();

    BIO *bio = BIO_new_file(privateKeyFile, "rb");
    if (!bio)
    {
        cerr << "Failed to open private key file." << endl;
        return 1;
    }

    RSA *rsa = PEM_read_bio_RSAPrivateKey(bio, NULL, NULL, NULL);
    if (!rsa)
    {
        BIO_reset(bio);
        rsa = d2i_RSAPrivateKey_bio(bio, NULL);
    }

    if (!rsa)
    {
        cerr << "Failed to read private key." << endl;
        BIO_free(bio);
        return 2;
    }
    BIO_free(bio);

    unsigned char hash[SHA256_DIGEST_LENGTH];
    try
    {
        ifstream inFile(filename, ios::binary);
        vector<unsigned char> fileContents((istreambuf_iterator<char>(inFile)), istreambuf_iterator<char>());
        SHA256(&fileContents[0], fileContents.size(), hash);
    }
    catch (exception &ex)
    {
        cerr << "Failed to read file." << endl;
        RSA_free(rsa);
        return 3;
    }

    EVP_PKEY *pkey = EVP_PKEY_new();
    EVP_PKEY_assign_RSA(pkey, rsa);

    EVP_MD_CTX *mdCtx = EVP_MD_CTX_new();
    EVP_PKEY_CTX *pkeyCtx = NULL;

    if (EVP_DigestSignInit(mdCtx, &pkeyCtx, EVP_sha256(), NULL, pkey) <= 0)
    {
        cerr << "Failed to initialize signing context." << endl;
        EVP_PKEY_free(pkey);
        EVP_MD_CTX_free(mdCtx);
        return 4;
    }

    if (EVP_PKEY_CTX_set_rsa_padding(pkeyCtx, RSA_PKCS1_PSS_PADDING) <= 0)
    {
        cerr << "Failed to set RSA PSS padding." << endl;
        EVP_PKEY_free(pkey);
        EVP_MD_CTX_free(mdCtx);
        return 5;
    }

    if (EVP_DigestSignUpdate(mdCtx, hash, SHA256_DIGEST_LENGTH) <= 0)
    {
        cerr << "Failed to update signing context." << endl;
        EVP_PKEY_free(pkey);
        EVP_MD_CTX_free(mdCtx);
        return 6;
    }

    size_t sigLen = 0;
    if (EVP_DigestSignFinal(mdCtx, NULL, &sigLen) <= 0)
    {
        cerr << "Failed to get signature length." << endl;
        EVP_PKEY_free(pkey);
        EVP_MD_CTX_free(mdCtx);
        return 7;
    }

    vector<unsigned char> signature(sigLen);
    if (EVP_DigestSignFinal(mdCtx, signature.data(), &sigLen) <= 0)
    {
        cerr << "Failed to generate signature." << endl;
        EVP_PKEY_free(pkey);
        EVP_MD_CTX_free(mdCtx);
        return 8;
    }

    ofstream outFile(signFile, ios::binary);
    outFile.write(reinterpret_cast<const char *>(signature.data()), sigLen);
    outFile.close();

    EVP_PKEY_free(pkey);
    EVP_MD_CTX_free(mdCtx);
    return 0;
}

int verify(const char *publicKeyFile, const char *filename, const char *signFile)
{
    OpenSSL_add_all_algorithms();
    ERR_load_crypto_strings();

    BIO *bio = BIO_new_file(publicKeyFile, "rb");
    if (!bio)
    {
        cerr << "Failed to open public key file." << endl;
        return 1;
    }

    RSA *rsa = PEM_read_bio_RSA_PUBKEY(bio, NULL, NULL, NULL);
    if (!rsa)
    {
        // Try another PEM format
        BIO_reset(bio);
        rsa = PEM_read_bio_RSAPublicKey(bio, NULL, NULL, NULL);
    }

    if (!rsa)
    {
        // Try BER format
        BIO_reset(bio);
        rsa = d2i_RSA_PUBKEY_bio(bio, NULL);
        if (!rsa)
        {
            BIO_reset(bio);
            rsa = d2i_RSAPublicKey_bio(bio, NULL);
        }
    }

    if (!rsa)
    {
        cerr << "Failed to read public key." << endl;
        ERR_print_errors_fp(stderr); // Print OpenSSL error messages
        BIO_free(bio);
        return 2;
    }
    BIO_free(bio);

    unsigned char hash[SHA256_DIGEST_LENGTH];
    try
    {
        ifstream inFile(filename, ios::binary);
        vector<unsigned char> fileContents((istreambuf_iterator<char>(inFile)), istreambuf_iterator<char>());
        SHA256(&fileContents[0], fileContents.size(), hash);
    }
    catch (exception &ex)
    {
        cerr << "Failed to read file." << endl;
        RSA_free(rsa);
        return 3;
    }

    EVP_PKEY *pkey = EVP_PKEY_new();
    EVP_PKEY_assign_RSA(pkey, rsa);

    EVP_MD_CTX *mdCtx = EVP_MD_CTX_new();
    EVP_PKEY_CTX *pkeyCtx = NULL;

    if (EVP_DigestVerifyInit(mdCtx, &pkeyCtx, EVP_sha256(), NULL, pkey) <= 0)
    {
        cerr << "Failed to initialize verification context." << endl;
        EVP_PKEY_free(pkey);
        EVP_MD_CTX_free(mdCtx);
        return 4;
    }

    if (EVP_PKEY_CTX_set_rsa_padding(pkeyCtx, RSA_PKCS1_PSS_PADDING) <= 0)
    {
        cerr << "Failed to set RSA PSS padding." << endl;
        EVP_PKEY_free(pkey);
        EVP_MD_CTX_free(mdCtx);
        return 5;
    }

    if (EVP_DigestVerifyUpdate(mdCtx, hash, SHA256_DIGEST_LENGTH) <= 0)
    {
        cerr << "Failed to update verification context." << endl;
        EVP_PKEY_free(pkey);
        EVP_MD_CTX_free(mdCtx);
        return 6;
    }

    ifstream sigFile(signFile, ios::binary);
    if (!sigFile.is_open())
    {
        cerr << "Failed to open signature file." << endl;
        EVP_PKEY_free(pkey);
        EVP_MD_CTX_free(mdCtx);
        return 7;
    }

    sigFile.seekg(0, ios::end);
    size_t sigLen = sigFile.tellg();
    sigFile.seekg(0, ios::beg);
    vector<unsigned char> signature(sigLen);
    sigFile.read(reinterpret_cast<char *>(&signature[0]), sigLen);
    sigFile.close();

    int verifyResult = EVP_DigestVerifyFinal(mdCtx, signature.data(), sigLen);
    if (verifyResult != 1)
    {
        EVP_PKEY_free(pkey);
        EVP_MD_CTX_free(mdCtx);
        return 8;
    }

    EVP_PKEY_free(pkey);
    EVP_MD_CTX_free(mdCtx);
    return 0;
}

int main(int argc, char *argv[])
{
    if (argc < 2)
    {
        std::cerr << "Usage: \n"
                  << argv[0] << " genkey <format> <privateKeyFile> <publicKeyFile> <keySize>\n"
                  << argv[0] << " sign <privateKeyFile> <inputFile> <signFile> \n"
                  << argv[0] << " verify <publicKeyFile> <inputFile> <signFile>\n";
        return -1;
    }

    OpenSSL_add_all_algorithms();
    ERR_load_crypto_strings();

    string mode = argv[1];

    if (mode == "genkey" && argc == 6)
    {
        const char *privateKeyFile = argv[2];
        const char *publicKeyFile = argv[3];
        const char *format = argv[4];
        const int keysize = stoi(argv[5]);

        // bool result = GenerateKeys(privateKeyFile, publicKeyFile, format, keysize);
        bool result = GenerateKeys(argv[2], argv[3], argv[4], stoi(argv[5]));
        if (GenerateKeys(argv[2], argv[3], argv[4], stoi(argv[5])))
        {
            cout << "Key generation successful." << endl;
        }
        else
        {
            cerr << "Key generation failed." << endl;
            return -1;
        }
    }
    else if (mode == "sign" && argc == 5)
    {
        const char *privateKeyFile = argv[2];
        const char *filename = argv[3];
        const char *signFile = argv[4];
        int result = -1;

        auto start = std::chrono::high_resolution_clock::now();
        for (int i = 0; i < 1000; i++)
        {
            // result = sign(privateKeyFile, filename, signFile);
            result = sign(argv[2], argv[3], argv[4]);
        }
        auto end = std::chrono::high_resolution_clock::now();
        auto duration = std::chrono::duration_cast<std::chrono::milliseconds>(end - start).count();
        double averageTime = static_cast<double>(duration) / 1000.0;
        std::cout << "Average time for signing over 1000 rounds: " << averageTime << " ms" << std::endl;

        if (result == 0)
        {
            cout << "Sign file sucessfully! " << endl;
        }
        else
        {
            cout << "Sign file unsucessfully!" << endl;
            return -1;
        }
    }
    else if (mode == "verify")
    {
        if (argc != 5)
        {
            cerr << "Usage: verify <public_key_file> <input_file> <signature_file>" << endl;
            return -1;
        }
        const char *publicKeyFile = argv[2];
        const char *filename = argv[3];
        const char *signFile = argv[4];

        int result = -1;
        auto start = std::chrono::high_resolution_clock::now();
        for (int i = 0; i < 1000; i++)
        {
            result = verify(publicKeyFile, filename, signFile);
        }
        auto end = std::chrono::high_resolution_clock::now();
        auto duration = std::chrono::duration_cast<std::chrono::milliseconds>(end - start).count();
        double averageTime = static_cast<double>(duration) / 1000.0;
        std::cout << "Average time for verifying over 1000 rounds: " << averageTime << " ms" << std::endl;

        if (result == 0)
        {
            cout << "Verify file sucessfully! " << endl;
        }
        else
        {
            cerr << "Verify file unsucessfully! " << result << endl;
            return -1;
        }
    }
    else
    {
        cerr << "Unknown argument: " << mode << endl;
        return -1;
    }

    ERR_free_strings();
    EVP_cleanup();

    return 0;
}
