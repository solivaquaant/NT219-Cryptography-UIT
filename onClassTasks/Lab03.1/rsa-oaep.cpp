// Linux help: http://www.cryptopp.com/wiki/Linux

// Debug:
// g++ -g -ggdb -O0 -Wall -Wextra -Wno-unused -Wno-type-limits -I. -I/usr/include/cryptopp cryptopp-key-gen.cpp -o cryptopp-key-gen.exe -lcryptopp

// Release:
// g++ -O2 -Wall -Wextra -Wno-unused -Wno-type-limits -I. -I/usr/include/cryptopp cryptopp-key-gen.cpp -o cryptopp-key-gen.exe -lcryptopp && strip --strip-all cryptopp-key-gen.exe
/* Integer arithmatics*/
#include "cryptopp/integer.h"
using CryptoPP::Integer;

#include "cryptopp/nbtheory.h"
using CryptoPP::ModularSquareRoot;

#include "cryptopp/modarith.h"
using CryptoPP::ModularArithmetic;

#include "cryptopp/osrng.h"
using CryptoPP::AutoSeededRandomPool;

#include <iostream>
using std::cout;
using std::cerr;
using std::endl;

#include <string>
using std::string;
// header part
#ifdef _WIN32
#include <windows.h>
#endif
#include <cstdlib>
#include <locale>
#include <cctype>

#include <stdexcept>
using std::runtime_error;

#include "cryptopp/queue.h"
using CryptoPP::ByteQueue;

#include "cryptopp/files.h"
using CryptoPP::FileSource;
using CryptoPP::FileSink;


#include "cryptopp/rsa.h"
using CryptoPP::RSA;
using CryptoPP::InvertibleRSAFunction;
using CryptoPP::RSAES_OAEP_SHA_Encryptor; // add
using CryptoPP::RSAES_OAEP_SHA_Decryptor; // add

#include "cryptopp/sha.h"
using CryptoPP::SHA1;
 // padding OAEP 

#include "cryptopp/filters.h"
using CryptoPP::PK_EncryptorFilter; 
using CryptoPP::PK_DecryptorFilter;
using CryptoPP::StringSink;
using CryptoPP::StringSource;

#include "cryptopp/base64.h"
using CryptoPP::Base64Encoder;
using CryptoPP::Base64Decoder;

#include "cryptopp/hex.h"
using CryptoPP::HexEncoder;
using CryptoPP::HexDecoder;

#include "cryptopp/cryptlib.h"
using CryptoPP::PrivateKey;
using CryptoPP::PublicKey;
using CryptoPP::BufferedTransformation;

#include "cryptopp/osrng.h"
using CryptoPP::AutoSeededRandomPool;



// SAVE KEY 
void Save(const string& filename, const BufferedTransformation& bt);
void SavePrivateKey(const string& filename, const PrivateKey& key);
void SavePublicKey(const string& filename, const PublicKey& key);

void SaveBase64(const string& filename, const BufferedTransformation& bt);
void SaveBase64PrivateKey(const string& filename, const PrivateKey& key);
void SaveBase64PublicKey(const string& filename, const PublicKey& key);

// LOAD KEY
void Load(const string& filename, BufferedTransformation& bt);
void LoadPrivateKey(const string& filename, PrivateKey& key);
void LoadPublicKey(const string& filename, PublicKey& key);

void LoadBase64(const string& filename, BufferedTransformation& bt);
void LoadBase64PrivateKey(const string& filename, PrivateKey& key);
void LoadBase64PublicKey(const string& filename, PublicKey& key);

// Key gen 
void GenerateAndSaveRSAKeys(int keySize, const char* format, const char* privateKeyFile, const char* publicKeyFile) {

	string strFormat(format);
	string strPrivateKeyFile(privateKeyFile);
	string strPublicKeyFile(publicKeyFile);


	AutoSeededRandomPool rnd;

		// Gen private key
		RSA::PrivateKey rsaPrivate;
		rsaPrivate.GenerateRandomWithKeySize(rnd, keySize);
		RSA::PublicKey rsaPublic(rsaPrivate);


		if (strFormat == "DER") {
			// bin
			SavePrivateKey(strPrivateKeyFile, rsaPrivate);
			SavePublicKey(strPublicKeyFile, rsaPublic);	
		}
		else if (strFormat == "Base64")
		{
			//base64
			SaveBase64PrivateKey(strPrivateKeyFile, rsaPrivate);
			SaveBase64PublicKey(strPublicKeyFile, rsaPublic);	
		}
		else 
		{
			cout << "Unsupported Format. Please choose 'DER' or 'Base64' " << endl; 
			exit(1);
		}
			
		Integer modul=rsaPrivate.GetModulus(); // modul n (from private)
        Integer prime1 = rsaPrivate.GetPrime1(); // prime p
        Integer prime2 = rsaPrivate.GetPrime2();  // prime q
		Integer SK=rsaPrivate.GetPrivateExponent(); // secret exponent d; 

              
        Integer PK= rsaPublic.GetPublicExponent(); // public exponent e; 
		Integer modul2=rsaPublic.GetModulus(); // modul n

		cout << "Modulo (private) n = " << modul << endl; 
		cout << "Modulo (public) n = " << modul2 << endl;
		cout << "Prime number p =  " << std::hex << prime1 << std::dec << endl; 
		cout << "Prime number q =  " << std::hex << prime2 << std::dec << endl; 
		cout << "Secret exponent d = " << SK << endl; 
		cout << "Public exponent e = " << PK << endl; // 17
		



		RSA::PrivateKey r1, r2;
		r1.GenerateRandomWithKeySize(rnd, 3072);

		SavePrivateKey("rsa-roundtrip.key", r1);
		LoadPrivateKey("rsa-roundtrip.key", r2);

		r1.Validate(rnd, 3);
		r2.Validate(rnd, 3);

		if(r1.GetModulus() != r2.GetModulus() ||
		   r1.GetPublicExponent() != r2.GetPublicExponent() ||
		   r1.GetPrivateExponent() != r2.GetPrivateExponent())
		{
			throw runtime_error("key data did not round trip");
		}
		
	

		cout << "Successfully generated and saved RSA keys" << endl;
}
// Ecrypt

void RSAEcrypt(const char* format, const char* publicKeyFile, const char* PlaintextFile, const char* CipherFile) {
	////////////////////////////////////////////////
	AutoSeededRandomPool rng;
        // convert char --> string 
		string strFormat(format);
		string strPublicKeyFile(publicKeyFile);		

        RSA::PrivateKey privateKey;
        RSA::PublicKey publicKey;
		string plain, cipher;
		if (strFormat == "DER") {
			//Load key
			LoadPublicKey(strPublicKeyFile, publicKey);
			// Load plain text 			
			FileSource(PlaintextFile, true, 
			new StringSink(plain)
			,false);

			// Init Encryption Function 
			////////////////////////////////////////////////
			// Encryption
			RSAES_OAEP_SHA_Encryptor e(publicKey);

			StringSource( plain, true,
				new PK_EncryptorFilter( rng, e,
					new FileSink(CipherFile, true)
				) // PK_EncryptorFilter
			); // StringSource

			cout << "Encrypt successfully! <DER>";
		}
		else if (strFormat == "Base64"){
			//Load key
			LoadBase64PublicKey(strPublicKeyFile, publicKey);
			// Load plain text 
			FileSource(PlaintextFile, true, 
			new HexEncoder(
				new StringSink(plain))
			,false);

			// Init Encryption Function 
			////////////////////////////////////////////////
			// Encryption
			RSAES_OAEP_SHA_Encryptor e(publicKey);

			StringSource( plain, true,
				new PK_EncryptorFilter( rng, e,
				new HexDecoder(
					new FileSink(CipherFile, true))
				) // PK_EncryptorFilter
			); // StringSource

			cout << "Encrypt successfully! <Base64>";
		}		 

		
}

void RSADecrypt(const char* format, const char* privateKeyFile, const char* CipherTextFile, const char* PlainTextFile) {
	RSA::PrivateKey privateKey;
    RSA::PublicKey publicKey;
	AutoSeededRandomPool rnd;

	LoadPrivateKey(privateKeyFile, privateKey);

	// Khởi tạo đối tượng để giải mã RSA
	RSAES_OAEP_SHA_Decryptor d(privateKey);

	string recover, cipher;

	// Đọc dữ liệu đã mã hóa từ tệp CipherFile
	FileSource(CipherTextFile, true, new StringSink(cipher));

	// Giải mã dữ liệu
		StringSource(cipher, true,
		new PK_DecryptorFilter(rnd, d,
			new StringSink(recover)
		) // PK_DecryptorFilter
	);
	cout << "recover: " << recover << endl;
	StringSource(cipher, true,
		new PK_DecryptorFilter(rnd, d,
			new FileSink(PlainTextFile,true)
		) // PK_DecryptorFilter
	);
}

// Decrypt


int main(int argc, char** argv)
{
	// main part
	// Set locale to support UTF-8
	#ifdef __linux__
		std::locale::global(std::locale("C.utf8"));
	#endif

	#ifdef _WIN32
	// Set console code page to UTF-8 on Windows C.utf8, CP_UTF8
		SetConsoleOutputCP(CP_UTF8);
		SetConsoleCP(CP_UTF8);
	#endif
	std::ios_base::sync_with_stdio(false);
	if (argc < 2) {
        cerr << "Usage: \n"
             << argv[0] << " genkey <keysize> <format> <privateKeyFile> <publicKeyFile>\n"
             << argv[0] << " encrypt <format> <publicKeyFile> <plaintextFile> <cipherFile>\n"
             << argv[0] << " decrypt <format> <privateKeyFile> <cipherFile> <plaintextFile>\n";
        return -1;
    }
 
    string mode = argv[1];
 
    if (mode == "genkey" && argc == 6) {
        int keySize = std::stoi(argv[2]);
        GenerateAndSaveRSAKeys(keySize, argv[3], argv[4], argv[5]);
    }
    else if (mode == "encrypt" && argc == 6) {
        RSAEcrypt(argv[2], argv[3], argv[4], argv[5]);
    }
	else if (mode == "decrypt" && argc == 6) {
		RSADecrypt(argv[2], argv[3], argv[4], argv[5]);
	}
    else {
        cerr << "Invalid arguments. Please check the usage instructions.\n";
        return -1;
    }
	
	

	

	return 0;
}

// DEF FUNCTION 
void SavePrivateKey(const string& filename, const PrivateKey& key)
{
	ByteQueue queue;
	key.Save(queue);
	Save(filename, queue);
}

void SavePublicKey(const string& filename, const PublicKey& key)
{
	
	ByteQueue queue;
	key.Save(queue);

	Save(filename, queue);
}

void Save(const string& filename, const BufferedTransformation& bt)
{
	FileSink file(filename.c_str());
	bt.CopyTo(file);
	file.MessageEnd();
}

void SaveBase64PrivateKey(const string& filename, const PrivateKey& key)
{
	// http://www.cryptopp.com/docs/ref/class_byte_queue.html
	ByteQueue queue;
	key.Save(queue);

	SaveBase64(filename, queue);
}

void SaveBase64PublicKey(const string& filename, const PublicKey& key)
{
	// http://www.cryptopp.com/docs/ref/class_byte_queue.html
	ByteQueue queue;
	key.Save(queue);

	SaveBase64(filename, queue);
}

void SaveBase64(const string& filename, const BufferedTransformation& bt)
{
	// http://www.cryptopp.com/docs/ref/class_base64_encoder.html
	Base64Encoder encoder;

	bt.CopyTo(encoder);
	encoder.MessageEnd();

	Save(filename, encoder);
}

void LoadPrivateKey(const string& filename, PrivateKey& key)
{
	// http://www.cryptopp.com/docs/ref/class_byte_queue.html
	ByteQueue queue;

	Load(filename, queue);
	key.Load(queue);	
}

void LoadPublicKey(const string& filename, PublicKey& key)
{
	// http://www.cryptopp.com/docs/ref/class_byte_queue.html
	ByteQueue queue;

	Load(filename, queue);
	key.Load(queue);	
}

void Load(const string& filename, BufferedTransformation& bt)
{
	// http://www.cryptopp.com/docs/ref/class_file_source.html
	FileSource file(filename.c_str(), true /*pumpAll*/);

	file.TransferTo(bt);
	bt.MessageEnd();
}

void LoadBase64PrivateKey(const string& filename, PrivateKey& key)
{
	throw runtime_error("Not implemented");
}

void LoadBase64PublicKey(const string& filename, PublicKey& key)
{
	throw runtime_error("Not implemented");
}

void LoadBase64(const string& filename, BufferedTransformation& bt)
{
	throw runtime_error("Not implemented");
}

