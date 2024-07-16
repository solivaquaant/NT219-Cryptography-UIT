# Cách cài đặt thư viện OpenFHE trên Windows
Xem chi tiết tại [đây](https://openfhe-development.readthedocs.io/en/latest/sphinx_rsts/intro/installation/windows.html).

## Cài đặt NTL/GMP
1. Tải từ [đây](https://libntl.org/download.html). 


## Cài đặt OpenFHE

1. Mở **MSYS2 MINGW 64 terminal** và chạy lệnh:  
```pacman -Syu```  
Nếu lần đầu chạy bị lỗi thì restart và chạy lại lệnh nha.

2. Chạy các lệnh sau:  
`pacman -S mingw-w64-x86_64-gcc`  
`pacman -S mingw-w64-x86_64-cmake`  
`pacman -S make`  
`pacman -S git`  

3. Clone repo:  
`git clone https://github.com/openfheorg/openfhe-development.git`

4. Trong thư mục repo vừa clone về, mở terminal và chạy:
`mkdir build`  
`cd build`  
`cmake ..`  

5. Chạy lệnh để cài autoconf:   
`pacman -S autoconf`

6. Build OpenFHE *(chạy sẽ tốn vài phút)*:  
`make -j 16`
