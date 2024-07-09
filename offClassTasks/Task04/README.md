# LAB 4: PKI and Hash Functions
## Task 4.1: Hash Functions
###  Separation all hash functions(using command-line or GUI)
SHA224, SHA256, SHA384, SHA512, SHA3-224, SHA3-256, SHA3-384, SHA3-512, SHAKE128,SHAKE256
###  Plaintext:
    - Support Vietnamese (UTF-8)
    - Input from screen or from file (using command-line or GUI)
###  Digest:
    - may choose digest output length d for SHAKE128,SHAKE256 from command-line arguments;
    - digest should be encoded as hex string án save to file or print to screen;
###  OS platforms
  - Your code can compile on both Windows and Linux;
###  Performance
  - Report your hardware resources
  - Report computation performance for all operations on both Windows and Linux with different input size;

## Task 4.2: PKI and digital certificate 
Code your tool using cryptopp or openssl that can  
  - Parse all the fields of a X.509 certificate, including subject name, issuer name, subject public key, signature, signature algorithms and its parameters, purposes, valid from and valid to dates, ...  
  - Check the validate of the signature;  
  - Input certificate from the file inform PEM (Base64) or DER (binary);
  - Output: return subject public key if the signature is valid and null otherwise;
       
## Task 4.3: Collision and length extension attacks on Hash functions
###  MD5 collision attacks
###  Two collision messages have the same prefix string
- Generate yourself prefix string
- Compute the two output files that have the same MD5 digest (using hashclash tool)
###  Two different C++ programs but have the same MD5;
- Code yourself two short C++ programs
- Compiler your codes code1, code2
- Run hashclash to generate two program with the same MD5 digest
Note: It takes long time to generate the output.
## Task 4.4 Length extension attacks on MAC  in form: H(k||m), k is secret key
###  show length extension attacks on MAC using SHA1, SHA256, SHA512 using hashpump tool;
###  Coding self programs that can attacks on MAC using SHA256 (for bonus 5/100 points)
- Automatic compute the padded part for any input (k||m);
- Compute the digest using length extension attacks with any extend string;
- 
## Task 4.5 attack on digital certificate (for bonus 10/100 points)
- generate a digital certificate using MD5 and RSA using openssl;
- compute an other digital certificate with the same signature but other subject using hashclash tool
