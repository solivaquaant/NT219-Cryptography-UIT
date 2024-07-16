# Compile CryptoPP library
## Windows
### Compile cryptopp library using g++
1. Run MSY2 Mingw 64 terminal:  
`make clean`
`make CXX="C:\msys64\mingw64\bin\g++.exe" -j 16`  
`make all CXX="C:\msys64\mingw64\bin\g++.exe" -j 16`  
`make test CXX="C:\msys64\mingw64\bin\g++.exe" -j 16`  

2. Copy library and header files  
`mkdir -p "include\cryptopp"`  
`mkdir lib`  
`cp *.h -p "include\cryptopp"`  
`cp *.a lib`  
3. Copy two folder "include" and "lib" to your projects

###  Set windows enviroment for clang, clang++
`mingw-w64-x86_64-clang`

### Compile cryptopp library using clang++
1. Run MSY2 Mingw 64 terminal:  
`make clean`   
`make CXX=C:\msys64\mingw64\bin\clang++.exe`   
`make all CXX="C:\msys64\mingw64\bin\clang++.exe" `  
`make test CXX="C:\msys64\mingw64\bin\clang++.exe"`  

2. Copy library and header files  
`mkdir -p "include\cryptoppclang"`  
`mkdir lib`  
`cp *.h -p "include\cryptoppclang"`  
`cp *.a lib`  
`cp *.so lib`  

3.  Copy two folder "include" and "libclang" to your projects

## Ubuntu
1. Change directory to cryptopp folder:  
`make clean`  
`make`  
`make all`  
`make test`  

2. Copy the cryptopp library   
`mkdir lib`  
`mkdir -p include/cryptopp`  
`cp *.h include/cryptopp`  
`cp *.a lib`  
`cp *.so lib`  

3. Copy two folder include and lib to your C++ project
>Note: you may install the cryptopp library using command: make install. The library will setup to the path: /usr/local
