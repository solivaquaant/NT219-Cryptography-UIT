// digital-sign-1.cpp
#include <openssl/evp.h>
#include <openssl/pem.h>
#include <openssl/err.h>
#include <openssl/sha.h> // Include for SHA256
#include <iostream>
#include <fstream>
#include <vector>   // Include for std::vector
#include <iterator> // Include for std::istreambuf_iterator

// Define DLL export macro
#ifndef DLL_EXPORT
#ifdef _WIN32
#define DLL_EXPORT __declspec(dllexport) // define class specifier
#else
#define DLL_EXPORT
#endif
#endif

extern "C"
{
    DLL_EXPORT bool signPdf(const char *chrprivateKeyPath, const char *chrpdfPath, const char *chrsignaturePath);
    DLL_EXPORT bool verifySignature(const char *chrpublicKeyPath, const char *chrpdfPath, const char *chrsignaturePath);
};

bool signPdf(const char *chrprivateKeyPath, const char *chrpdfPath, const char *chrsignaturePath)
{
    std::string privateKeyPath(chrprivateKeyPath);
    std::string pdfPath(chrpdfPath);
    std::string signaturePath(chrsignaturePath);

    OpenSSL_add_all_algorithms();
    ERR_load_crypto_strings();

    // Read the private key from file
    BIO *keyData = BIO_new(BIO_s_file());
    BIO_read_filename(keyData, privateKeyPath.c_str());
    EVP_PKEY *privateKey = PEM_read_bio_PrivateKey(keyData, NULL, NULL, NULL);
    BIO_free(keyData); // Close

    if (!privateKey)
    {
        std::cerr << "Error reading private key." << std::endl;
        ERR_print_errors_fp(stderr);
        return false;
    }

    // Create a buffer to hold the document hash
    unsigned char hash[SHA256_DIGEST_LENGTH]; // output size for hash function
    // Read input message (binary)
    std::ifstream pdfFile(pdfPath, std::ios::binary);
    if (!pdfFile.is_open())
    {
        std::cerr << "Error opening PDF file." << std::endl;
        return false;
    }
    // Convert thành byte (giảm độ dài xuống)
    std::vector<unsigned char> pdfContents((std::istreambuf_iterator<char>(pdfFile)), std::istreambuf_iterator<char>());
    pdfFile.close();

    // Hash the PDF
    std::cout << "Hashing the PDF" << std::endl;
    SHA256(&pdfContents[0], pdfContents.size(), hash);

    // Sign the hash
    std::cout << "Signing the hash" << std::endl;
    EVP_MD_CTX *mesData = EVP_MD_CTX_new();
    EVP_SignInit(mesData, EVP_sha256()); // Initialize sign funtion
    EVP_SignUpdate(mesData, hash, SHA256_DIGEST_LENGTH);

    // Convert key to bytes
    unsigned int signatureLen = EVP_PKEY_size(privateKey);
    std::vector<unsigned char> signature(signatureLen);

    if (!EVP_SignFinal(mesData, &signature[0], &signatureLen, privateKey))
    {
        std::cerr << "Error signing PDF." << std::endl;
        EVP_MD_CTX_free(mesData);
        EVP_PKEY_free(privateKey);
        return false;
    }

    // Write the signature to a file
    std::cout << "Writing the signature to file: " << signaturePath << std::endl;
    std::ofstream signatureFile(signaturePath, std::ios::binary);
    if (!signatureFile.is_open())
    {
        std::cerr << "Error opening signature file." << std::endl;
        return false;
    }
    signatureFile.write(reinterpret_cast<const char *>(&signature[0]), signatureLen);
    signatureFile.close();

    // Clean up
    EVP_MD_CTX_free(mesData);
    EVP_PKEY_free(privateKey);
    EVP_cleanup();
    ERR_free_strings();
    return true;
}
bool verifySignature(const char *chrpublicKeyPath, const char *chrpdfPath, const char *chrsignaturePath)
{
    std::string publicKeyPath(chrpublicKeyPath);
    std::string pdfPath(chrpdfPath);
    std::string signaturePath(chrsignaturePath);

    // Load the public key (PEM) using BIO
    BIO *pubData = BIO_new(BIO_s_file());
    if (BIO_read_filename(pubData, publicKeyPath.c_str()) <= 0)
    {
        std::cerr << "Error opening public key file." << std::endl;
        BIO_free(pubData);
        return false;
    }

    EVP_PKEY *publicKey = PEM_read_bio_PUBKEY(pubData, NULL, NULL, NULL);
    BIO_free(pubData);

    if (!publicKey)
    {
        std::cerr << "Error loading public key." << std::endl;
        return false;
    }

    // Load the PDF
    std::ifstream pdfFile(pdfPath, std::ios::binary);
    std::vector<unsigned char> pdfContents((std::istreambuf_iterator<char>(pdfFile)), std::istreambuf_iterator<char>());
    pdfFile.close();

    // Create a buffer to hold the document hash
    unsigned char hash[SHA256_DIGEST_LENGTH];
    SHA256(&pdfContents[0], pdfContents.size(), hash);

    // Load the signature
    std::ifstream signatureFile(signaturePath, std::ios::binary);
    std::vector<unsigned char> signature(std::istreambuf_iterator<char>(signatureFile), {});
    signatureFile.close();

    // Verify the signature
    EVP_MD_CTX *mesData = EVP_MD_CTX_new();
    EVP_DigestVerifyInit(mesData, NULL, EVP_sha256(), NULL, publicKey);
    EVP_DigestVerifyUpdate(mesData, hash, SHA256_DIGEST_LENGTH);
    int result = EVP_DigestVerifyFinal(mesData, &signature[0], signature.size());

    // Clean up
    EVP_MD_CTX_free(mesData);
    EVP_PKEY_free(publicKey);

    return result == 1;
}

int main(int argc, char *argv[])
{

    if (argc < 2)
    {
        std::cerr << "Usage: " << argv[0] << "[sign|verify] [other parameters]" << std::endl;
        return 1;
    }
    std::string mode(argv[1]);

    if (mode == "sign")
    {
        if (argc != 5)
        {
            std::cerr << "Usage: " << argv[0] << " sign <private key file> <PDF file> <signature output file>" << std::endl;
            return 1;
        }
        // const std::string privateKeyPath = argv[2];
        // const std::string pdfPath = argv[3];
        // const std::string signaturePath = argv[4];

        if (signPdf(argv[2], argv[3], argv[4]))
        {
            std::cout << "PDF signed successfully and saved to " << argv[4] << std::endl;
        }
        else
        {
            std::cout << "Failed to sign PDF." << std::endl;
        }
        return 0;
    }
    else if (mode == "verify")
    {
        if (argc != 5)
        {
            std::cerr << "Usage: " << argv[0] << " verify <public key file> <PDF file> <signature file>" << std::endl;
            return 1;
        }
        // const std::string publicKeyPath = argv[2];
        // const std::string pdfPath = argv[3];
        // const std::string signaturePath = argv[4];
        if (verifySignature(argv[2], argv[3], argv[4]))
        {
            std::cout << "PDF verified successfully." << std::endl;
        }
        else
        {
            std::cout << "Failed to verify PDF." << std::endl;
        }
        return 0;
    }
    else
    {
        std::cerr << "Invalid mode! Please choose sign or verify!" << std::endl;
        return 1;
    }
    return 0;
}
