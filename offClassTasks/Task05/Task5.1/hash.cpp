// Hash fuction using switch case:
#include <iostream>
#include <string>
using std::cin;
using std::cout;
using std::string;

#ifdef _WIN32
#include <io.h>
#include <fcntl.h>
#include <windows.h>
#endif
#include <fstream>
#include <locale>
#include <chrono>

// Cryptopp library
#include <cryptopp/cryptlib.h>
#include "cryptopp/sha3.h"
#include "cryptopp/sha.h"
#include "cryptopp/shake.h"
#include "cryptopp/hex.h"
#include "cryptopp/files.h"
using CryptoPP::FileSink;

int main(int argc, char *argv[])
{
// support for Vietnamese
#ifdef _WIN32
    SetConsoleOutputCP(CP_UTF8);
    SetConsoleCP(CP_UTF8);
#endif
    string mode;
    std::unique_ptr<CryptoPP::HashTransformation> hash;

    cout << "Enter hash type: (SHA224, SHA256, SHA384, SHA512, SHA3-224, SHA3-256, SHA3-384, SHA3-512, SHAKE128,SHAKE256)" << std::endl;
    getline(cin, mode);
    if (mode == "SHA224")
        hash.reset(new SHA224);
}