import ctypes
from ctypes import c_char_p
import sys
import os

sopath = os.path.join(os.getcwd(), "digital-opensslDLL.so")
lib=ctypes.CDLL(sopath)

signPdf = lib.signPdf
signPdf.argtypes =[c_char_p,c_char_p, c_char_p]
signPdf.restype= bool

verifySignature = lib.verifySignature
verifySignature.argtypes =[c_char_p,c_char_p, c_char_p]
verifySignature.restype= bool

def call_signPdf(privateKey, pdfFile,signFile):
    privateKey=privateKey.encode('utf-8')
    pdfFile=pdfFile.encode('utf-8')
    signFile=signFile.encode('utf-8')
    signPdf(privateKey, pdfFile, signFile)

def call_verifySignature(publicKey, pdfFile,signFile):
    publicKey=publicKey.encode('utf-8')
    pdfFile=pdfFile.encode('utf-8')
    signFile=signFile.encode('utf-8')
    verifySignature(publicKey, pdfFile, signFile)
 

if __name__ == "__main__":
    if len(sys.argv) < 2:
        print(f"Usage: python {sys.argv[0]} [sign|verify] [other parameters]")
        sys.exit(1)

    mode = sys.argv[1]
    if (mode == "sign"):
        if len(sys.argv) != 5:
            print(f"Usage: {sys.argv[0]} sign <private key file> <PDF file> <signature output file>")
            sys.exit(1)

        private_key_path = sys.argv[2]
        pdf_path = sys.argv[3]
        signature_path = sys.argv[4]

        call_signPdf(private_key_path, pdf_path, signature_path)

    elif mode == "verify":
        if len(sys.argv) != 5:
            print(f"Usage: {sys.argv[0]} verify <public key file> <PDF file> <signature file>")
            sys.exit(1)
        public_key_path = sys.argv[2]
        pdf_path = sys.argv[3]
        signature_path = sys.argv[4]
        call_verifySignature(public_key_path, pdf_path, signature_path)
 
    else:
        print("Invalid mode! Please choose sign or verify!")
        sys.exit(1)

    sys.exit(0)