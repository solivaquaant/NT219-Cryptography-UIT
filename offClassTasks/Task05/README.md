# LAB 5: Digital signature with CryptoPP/Openssl
Required:
### Algorithm: ECDSA, RSASS-PSS
### Three module: key generation, signing and the verify functions (using command-line or GUI)
## Key generation
  Publickey, Privae  Key;
  Save to file s (ber, pem);
## signing function
    - May adopt library or direct compute from formulas.
    - Deploy directly from formulas will get 15/100 bonus points.
### Message to sign
    - Input from file or screen
    - Support Vietnamese (using UTF-8)
### secret key
   - Input from file
## Verify function
### Message and signature
    - Input from files
    - Support Vietnamese (using UTF-8)
### public key key
   - Input from file
 
## ECC curve:  should select from standard curves
### Secret key/public key
    - The keys load from files (for both two functions and arguments in C++/C# in terminal or GUI)
    - The public key: >= 256 bits
### OS platforms
  - Your code can compile on both Windows and Linux;
