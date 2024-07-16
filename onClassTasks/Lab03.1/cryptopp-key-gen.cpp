// Linux help: http://www.cryptopp.com/wiki/Linux

// Debug:
// g++ -g -ggdb -O0 -Wall -Wextra -Wno-unused -Wno-type-limits -I. -I/usr/include/cryptopp cryptopp-key-gen.cpp -o cryptopp-key-gen.exe -lcryptopp

// Release:
// g++ -O2 -Wall -Wextra -Wno-unused -Wno-type-limits -I. -I/usr/include/cryptopp cryptopp-key-gen.cpp -o cryptopp-key-gen.exe -lcryptopp && strip --strip-all cryptopp-key-gen.exe

// DER, bin, Base64
// PEM: tim hieu ve PEM Pack

#include <iostream>
using std::cerr;
using std::cin;
using std::cout;
using std::endl;

#include <string>
using std::string;

#include <stdexcept>
using std::runtime_error;
// CryptoPP
/* Integer arithmatics*/
#include <cryptopp/integer.h>
using CryptoPP::Integer;

#include <cryptopp/nbtheory.h>
using CryptoPP::ModularSquareRoot;

#include <cryptopp/modarith.h>
using CryptoPP::ModularArithmetic;

#include <cryptopp/queue.h>
using CryptoPP::ByteQueue;

#include <cryptopp/files.h>
using CryptoPP::FileSink;
using CryptoPP::FileSource;

#include "cryptopp/rsa.h"
using CryptoPP::RSA;

#include "cryptopp/base64.h"
using CryptoPP::Base64Decoder;
using CryptoPP::Base64Encoder;

#include <cryptopp/cryptlib.h>
using CryptoPP::BufferedTransformation;
using CryptoPP::PrivateKey;
using CryptoPP::PublicKey;

#include "cryptopp/osrng.h"
using CryptoPP::AutoSeededRandomPool;

// Keys (binary)
void Save(const string &filename, const BufferedTransformation &bt);
void SavePrivateKey(const string &filename, const PrivateKey &key);
void SavePublicKey(const string &filename, const PublicKey &key);

// Keys (text)
void SaveBase64(const string &filename, const BufferedTransformation &bt);
void SaveBase64PrivateKey(const string &filename, const PrivateKey &key);
void SaveBase64PublicKey(const string &filename, const PublicKey &key);

void Load(const string &filename, BufferedTransformation &bt);
void LoadPrivateKey(const string &filename, PrivateKey &key);
void LoadPublicKey(const string &filename, PublicKey &key);

void LoadBase64(const string &filename, BufferedTransformation &bt);
void LoadBase64PrivateKey(const string &filename, PrivateKey &key);
void LoadBase64PublicKey(const string &filename, PublicKey &key);

void GenerateAndSaveRSAKeys(int keySize, const char *format, const char *PrivateKeyFile, const char *PublicKeyFile)
{
	string strFormat(format);
	string strPrivateKeyFile(PrivateKeyFile);
	string strPublicKeyFile(PublicKeyFile);

	// Key Gen
	AutoSeededRandomPool rnd;
	RSA::PrivateKey rsaPrivate;
	rsaPrivate.GenerateRandomWithKeySize(rnd, keySize);
	RSA::PublicKey rsaPublic(rsaPrivate);

	if (strFormat == "DER") // bin
	{
		SavePrivateKey(strPrivateKeyFile, rsaPrivate);
		SavePublicKey(strPublicKeyFile, rsaPublic);
	}
	else if (strFormat == "Base64")
	{
		SaveBase64PrivateKey(strPrivateKeyFile, rsaPrivate);
		SaveBase64PublicKey(strPublicKeyFile, rsaPublic);
	}
	else
	{
		cerr << "Unsupported format, please choose DER or Base64" << endl;
		exit(1);
	}

	// Get system parameters
	Integer modul1 = rsaPrivate.GetModulus();	  // modul n from Prive
	Integer prime1 = rsaPrivate.GetPrime1();	  // prime p
	Integer prime2 = rsaPrivate.GetPrime2();	  // prime p
	Integer SK = rsaPrivate.GetPrivateExponent(); // secret exponent d;  =e

	Integer modul2 = rsaPublic.GetModulus();	// modul n from Public
	Integer PK = rsaPublic.GetPublicExponent(); // public exponent e;

	cout << "Module n (private) = " << modul1 << endl;
	cout << "Module n (public) = " << modul2 << endl;
	cout << "Prime number p (private) = " << std::hex << prime1 << std::dec << endl;
	cout << "Prime number q (private) = " << prime2 << endl;
	cout << "Public exponent e = " << PK << endl;
	cout << "Secret exponent d = " << SK << endl;

	// Checking the key generator funtion
	RSA::PrivateKey r1, r2;
	r1.GenerateRandomWithKeySize(rnd, 3072);

	SavePrivateKey("rsa-roundtrip.key", r1);
	LoadPrivateKey("rsa-roundtrip.key", r2);

	r1.Validate(rnd, 3);
	r2.Validate(rnd, 3);

	if (r1.GetModulus() != r2.GetModulus() ||
		r1.GetPublicExponent() != r2.GetPublicExponent() ||
		r1.GetPrivateExponent() != r2.GetPrivateExponent())
	{
		throw runtime_error("key data did not round trip");
	}
	cout << "Successfully generated and saved RSA and DSA keys" << endl;
}

int main(int argc, char **argv)
{
	std::ios_base::sync_with_stdio(false);

	AutoSeededRandomPool rnd;

	if (argc != 5)
	{
		cerr << "UsageL " << argv[0] << "<keySize> <format> <privateKeyFile> <publicKeyFile>" << endl;
		cerr << "keySizeL number of bít for key size (e.g., 2048, 3072)" << endl;
		cerr << "format: Key format (DER, Base64...)" << endl;
		return -1;
	}
	int KeySize = std::stoi(argv[1]);
	const char *format = argv[2];
	const char *PrivateKeyFile = argv[3];
	const char *PublicKeyFile = argv[4];
	GenerateAndSaveRSAKeys(KeySize, format, PrivateKeyFile, PublicKeyFile);

	return 0;
}

void SavePrivateKey(const string &filename, const PrivateKey &key)
{
	// http://www.cryptopp.com/docs/ref/class_byte_queue.html
	ByteQueue queue;
	key.Save(queue);

	Save(filename, queue);
}

void SavePublicKey(const string &filename, const PublicKey &key)
{
	// http://www.cryptopp.com/docs/ref/class_byte_queue.html
	ByteQueue queue;
	key.Save(queue);

	Save(filename, queue);
}

void Save(const string &filename, const BufferedTransformation &bt)
{
	// http://www.cryptopp.com/docs/ref/class_file_sink.html
	FileSink file(filename.c_str());

	bt.CopyTo(file);
	file.MessageEnd();
}

void SaveBase64PrivateKey(const string &filename, const PrivateKey &key)
{
	// http://www.cryptopp.com/docs/ref/class_byte_queue.html
	ByteQueue queue;
	key.Save(queue);

	SaveBase64(filename, queue);
}

void SaveBase64PublicKey(const string &filename, const PublicKey &key)
{
	// http://www.cryptopp.com/docs/ref/class_byte_queue.html
	ByteQueue queue;
	key.Save(queue);

	SaveBase64(filename, queue);
}

void SaveBase64(const string &filename, const BufferedTransformation &bt)
{
	// http://www.cryptopp.com/docs/ref/class_base64_encoder.html
	Base64Encoder encoder;

	bt.CopyTo(encoder);
	encoder.MessageEnd();

	Save(filename, encoder);
}

void LoadPrivateKey(const string &filename, PrivateKey &key)
{
	// http://www.cryptopp.com/docs/ref/class_byte_queue.html
	ByteQueue queue;

	Load(filename, queue);
	key.Load(queue);
}

void LoadPublicKey(const string &filename, PublicKey &key)
{
	// http://www.cryptopp.com/docs/ref/class_byte_queue.html
	ByteQueue queue;

	Load(filename, queue);
	key.Load(queue);
}

void Load(const string &filename, BufferedTransformation &bt)
{
	// http://www.cryptopp.com/docs/ref/class_file_source.html
	FileSource file(filename.c_str(), true /*pumpAll*/);

	file.TransferTo(bt);
	bt.MessageEnd();
}

void LoadBase64PrivateKey(const string &filename, PrivateKey &key)
{
	throw runtime_error("Not implemented");
}

void LoadBase64PublicKey(const string &filename, PublicKey &key)
{
	throw runtime_error("Not implemented");
}

void LoadBase64(const string &filename, BufferedTransformation &bt)
{
	throw runtime_error("Not implemented");
}
