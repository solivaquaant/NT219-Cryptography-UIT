// header part
#ifdef _WIN32
#include <windows.h>
#endif
#include <cstdlib>
#include <locale>
#include <cctype>

#include <iostream>
using std::cerr;
using std::cin;
using std::cout;
using std::endl;

#include <string>
using std::string;

#include <cstdlib>
using std::exit;

// CryptoPP
/* Integer arithmatics*/
#include <cryptopp/integer.h>
using CryptoPP::Integer;

#include <cryptopp/nbtheory.h>
using CryptoPP::ModularSquareRoot;

#include <cryptopp/modarith.h>
using CryptoPP::ModularArithmetic;

#include "cryptopp/osrng.h"
using CryptoPP::AutoSeededRandomPool;

#include "cryptopp/cryptlib.h"
using CryptoPP::Exception;

#include "cryptopp/hex.h"
using CryptoPP::HexDecoder;
using CryptoPP::HexEncoder;

#include "cryptopp/filters.h"
using CryptoPP::StreamTransformationFilter;
using CryptoPP::StringSink;
using CryptoPP::StringSource;

int main(int argc, char *argv[])
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

    AutoSeededRandomPool prng;
    Integer p("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFh");
    Integer x("1234567891012.");
    Integer y(prng, 1, p);
    cout << "x = " << x << endl;

    cout << "y = " << y << endl;
    cout << "p = " << p << endl;

    ModularArithmetic ma(p); // mod p
    cout << "x+y mod p: " << ma.Add(x, y) << endl;
    cout << "x-y mod p: " << ma.Subtract(x, y) << endl;
    cout << "x*y mod p: " << ma.Multiply(x, y) << endl;
    cout << "x/y mod p: " << ma.Divide(x, y) << endl;
    cout << "x%y mod p: " << ma.Reduce(x, y) << endl;
    cout << "x^y mod p: " << ma.Exponentiate(x, y) << endl;

    // Validation x*x^-1 = 1
    Integer x1 = ma.Divide(1, x);
    cout << "x*x^-1 mod p: " << ma.Multiply(x, x1) << endl;
    cout << "x^-1 = " << x1 << endl;
    string mes, hexmes;

    // String to Integer

    string ss, hexss;
    cout << "Input message: ";
    getline(cin, ss);
    StringSource(ss, true, new HexEncoder(new StringSink(hexss)));
    hexss = hexss + "H";
    Integer u(hexss.c_str());
    cout << "Convert message to integer " << endl;

    string recover, hexrecover;
    hexrecover = IntToString(u, 16);
    StringSource(hexrecover, true, new HexDecoder(new StringSink(recover)));
    cout << "Hex string of the message: " << hexrecover << endl;
    cout << "Recover Integer to message: " << recover;
}