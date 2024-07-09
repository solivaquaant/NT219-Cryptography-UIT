#include <iostream>
#include <fstream>
#include <iomanip>
#include <sstream>
#include <chrono>

using std::endl;
#include <string>
using std::string;

#include <cstdlib>
#include <cstdint>
using std::exit;
#include "assert.h"
#include <locale>

#ifdef _WIN32
#include <windows.h>
#endif

#include <locale>
#include <codecvt>

#include "CBC_mode.h"
#include "AES.h"

using namespace std;

string KEY, IV, line, plain, cipher, encoded, recover;
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
    DLL_EXPORT const char *AESEncrypt(const char *keyFile, const char *ivFile, const char *plainText);
    DLL_EXPORT const char *AESDecrypt(const char *keyFile, const char *ivFile, const char *cipherText);
};

vector<uint8_t> str2vector(string str);
string vector2str(vector<uint8_t> byteVector);
std::vector<uint8_t> hex2byte(std::string hexStr);
string byte2hex(vector<uint8_t> byteVector);

const char *AESEncrypt(const char *keyFile, const char *ivFile, const char *plainText)
{
    string strKeyFile(keyFile);
    string strIVFile(ivFile);

    // Load key from file
    std::ifstream fileKey(strKeyFile);
    if (fileKey.is_open())
    {
        while (std::getline(fileKey, line))
        {
            KEY = line;
        }
        fileKey.close();
    }
    else
    {
        std::cerr << "Can't open file " << strKeyFile << std::endl;
        exit(1);
    }

    // Load IV fromm file
    std::ifstream fileIV(strIVFile);
    if (fileIV.is_open())
    {
        while (std::getline(fileIV, line))
        {
            IV = line;
        }
        fileIV.close();
    }
    else
    {
        std::cerr << "Can't open file " << strIVFile << std::endl;
        exit(1);
    }

    // Encrypt
    /* chuyển thành vector để encrypt*/
    vector<uint8_t> byte_pl = str2vector(plain);
    vector<uint8_t> byte_key = str2vector(KEY);
    vector<uint8_t> byte_iv = str2vector(IV);

    /*tạo một đối tượng CBC mode*/
    CBC_mode mode = CBC_mode(byte_key, byte_iv);
    vector<uint8_t> enc_data;

    /*encrypting*/
    auto start = std::chrono::high_resolution_clock::now();
    for (int i = 0; i < 10000; ++i)
    {
        // Encryption logic here
        enc_data = mode.cbc_encrypt(byte_pl);
    }
    auto end = std::chrono::high_resolution_clock::now();
    auto duration = std::chrono::duration_cast<std::chrono::milliseconds>(end - start).count();
    double averageTime = static_cast<double>(duration) / 10000.0;
    std::cout << "Average time for encryption over 2 rounds: " << averageTime << " ms" << std::endl;

    // Save cipher text to file
    std::string hexString;
    hexString = byte2hex(enc_data);
    const char *result = hexString.c_str();
    return result;
}

const char *AESDecrypt(const char *keyFile, const char *ivFile, const char *cipherText)
{

    string strKeyFile(keyFile);
    string strIVFile(ivFile);

    // Load key from file
    std::ifstream fileKey(strKeyFile);
    if (fileKey.is_open())
    {
        while (std::getline(fileKey, line))
        {
            KEY = line;
        }
        fileKey.close();
    }
    else
    {
        std::cerr << "Can't open file " << strKeyFile << std::endl;
        exit(1);
    }

    // Load IV from file
    std::ifstream fileIV(strIVFile);
    if (fileIV.is_open())
    {
        while (std::getline(fileIV, line))
        {
            IV = line;
        }
        fileIV.close();
    }
    else
    {
        std::cerr << "Can't open file " << strIVFile << std::endl;
        exit(1);
    }

    // Decrypt
    /* chuyển thành vector để encrypt*/
    vector<uint8_t> byte_pl = str2vector(plain);
    vector<uint8_t> byte_key = str2vector(KEY);
    vector<uint8_t> byte_iv = str2vector(IV);

    /*tạo một đối tượng CBC mode*/
    CBC_mode mode = CBC_mode(byte_key, byte_iv);
    vector<uint8_t> dec_data;
    auto start = std::chrono::high_resolution_clock::now();
    for (int i = 0; i < 2; ++i)
    {
        // Encryption logic here
        dec_data = mode.cbc_decrypt(hex2byte(cipher));
    }

    auto end = std::chrono::high_resolution_clock::now();
    auto duration = std::chrono::duration_cast<std::chrono::milliseconds>(end - start).count();
    double averageTime = static_cast<double>(duration) / 2.0;
    std::cout << "Average time for encryption over 2 rounds: " << averageTime << " ms" << std::endl;

    string recovered = vector2str(dec_data);

    const char *result = recovered.c_str();
    return result;
}

int main(int argc, char *argv[])
{
#ifdef _WIN32
    SetConsoleOutputCP(CP_UTF8);
    SetConsoleCP(CP_UTF8);
#endif
    if (argc < 2)
    {
        cout << "Usage: " << endl
             << "encrypt <keyFile> <ivFile> <plainTextFile> <cipherTextFile>" << endl
             << "decrypt <keyFile> <ivFile> <cipherTextFile> <recoverTextFile>" << endl;
        return 1;
    }
    string mode(argv[1]);
    if (mode == "encrypt")
    {
        cout << AESEncrypt(argv[2], argv[3], argv[4]);
    }
    else if (mode == "decrypt")
    {
        cout << AESDecrypt(argv[2], argv[3], argv[4]);
    }
    else
    {
        cout << "Invalid argument: " << mode << endl;
        return 1;
    }
    return 0;
}

vector<uint8_t> str2vector(string str)
{
    // Chuyển đổi string UTF-8 thành vector<uint8_t>
    std::vector<uint8_t> byteVector(str.begin(), str.end());
    return byteVector;
}

/*từ vector byte chuyển sang wstring*/
string vector2str(vector<uint8_t> byteVector)
{
    // Khởi tạo locale với codecvt
    std::locale loc(std::locale(), new std::codecvt_utf8<wchar_t>);

    // Chuyển đổi vector<uint8_t> thành chuỗi UTF-8
    std::string utf8Str(byteVector.begin(), byteVector.end());
    // Chuyển đổi chuỗi UTF-8 thành wstring
    return utf8Str;
}

/*từ hex chuyển sang vector byte*/
std::vector<uint8_t> hex2byte(std::string hexStr)
{
    std::vector<uint8_t> byteVector;
    for (size_t i = 0; i < hexStr.size(); i += 2)
    {
        // Lấy cặp ký tự hex từ chuỗi UTF-8 và chuyển đổi thành giá trị uint8_t
        std::string byteStr = hexStr.substr(i, 2);
        uint8_t byte = static_cast<uint8_t>(std::stoul(byteStr, nullptr, 16));
        byteVector.push_back(byte);
    }
    return byteVector;
}
string byte2hex(vector<uint8_t> byteVector)
{
    stringstream ss;
    string result;
    for (int i = 0; i < int(byteVector.size()); i++)
    {
        ss << hex << setw(2) << setfill('0') << (unsigned int)(byteVector[i] & 0xff);
    }
    result = ss.str();
    return result;
}