import ctypes
from ctypes import c_char_p
import sys
import os

sopath = os.path.join(os.getcwd(), "shas.dll")
lib=ctypes.CDLL(sopath)

hashes = lib._Z6hashesPKcS0_S0_
hashes.argtypes =[c_char_p,c_char_p, c_char_p]
hashes.restype= None

def call_hashes(algo, inputFilename, outputFilename):
    algo=algo.encode('utf-8')
    inputFilename=inputFilename.encode('utf-8')
    outputFilename=outputFilename.encode('utf-8')
    hashes(algo, inputFilename, outputFilename)

if __name__ == "__main__":
    if(len(sys.argv)!=4):
        print(f"Usage: python {sys.argv[0]} <algo> <inputFilename> <outputFilename>")
        sys.exit(1)

algo=sys.argv[1]
inputFilename = sys.argv[2]
outputFilename = sys.argv[3]

call_hashes(algo, inputFilename, outputFilename)
print(f"Hash saved to {sys.argv[3]}") 


