# Setup G++ and Visual Studio Code
## Windows
### Install code editor (Visual Studio Code)
Install [here](https://code.visualstudio.com/download).

### Install C++ compile library (MinGW-w64)
> Note: you shoud disable all old version off gcc and g++  

### Setup msys2
1. Download msys2 at: https://www.msys2.org/
2. Install msys2
3. Update packages:  
    `pacman -Syu`  
	`pacman -Su`
4. Install gcc, g++ compile
	pacman -S git mingw-w64-x86_64-gcc base-devel
	pacman -S mingw-w64-cross-binutils

###  Set windows enviroment for g++, gcc 
1. Open System Properties box
	+ **Method 1:** Search: env -> open: "Edit the system environment variables"
	+ **Method 2**: Open: Control panel-> System -> Advanced system settings -> Advanced)
2. Set path g++, gcc for "environment variables"
	+ Click open "environment variables" and open "path" at box "System variables"  
	+ Select "new", then add two line more belows   
	`C:\msys64\mingw64\bin`  
	`C:\msys64\usr\bin`

> Note: Check for sure that mingw64 was install in the *"C:\msys64"*. If msys64 did not install in default path, you have to change the default path *"C:\msys64\mingw64\bin"* to the msys64 location path on your PC. 

## Ubuntu
### Setup Visual Studio Code
1. Update packages  
`sudo apt update`  
`sudo apt install software-properties-common apt-transport-https wget`  

2. import the Microsoft GPG key  
`wget -q https://packages.microsoft.com/keys/microsoft.asc -O- | sudo apt-key add -`

3. Enable Visual Studio Code repository  
`sudo add-apt-repository "deb [arch=amd64] https://packages.microsoft.com/repos/vscode stable main"`

4. Install the Visual Studio Code  
`sudo apt update`  
`sudo apt install code`

### Setup c++ compile 
1. Setup Ubuntu tool chains  
`sudo add-apt-repository ppa:ubuntu-toolchain-r/test`  
`sudo apt-get update`  

2. Setup build-essential  
`sudo apt install build-essential`  
`sudo apt-get install manpages-dev`  

3. Setup g++-10 and gcc-10 compile  
`sudo apt-get install g++-10`  
`sudo apt-get install gcc-10`  

4. Check g++, gcc, g++-10, gcc-10  
`g++-10 --version`  
`gcc-10 --version`  
`gcc --version`  
`g++ --version`  