HƯỚNG DẪN COMPILE C++ CODE TRONG WINDOW SỬ DỤNG VISUAL STUDIO CODE
# Hướng dẫn compilee C++ code sử dụng Visual Studio Code
##	Tích hợp các thư viện mở rộng
Các thư viện mở rộng (ví dụ cryptopp) sau khi compile cần copy cả file thư viện *(.a, .so, .dll)* vào project C++ đang làm việc.  
Ví dụ: Sau khi compile cryptopp:
-	Copy các file header (.h) vào thư mục: include\cryptopp
-	Copy file thư viện  libcryptopp.a và libcryptopp.so vào thư mục lib. 
-	Copy cả hai thư mục include và lib vào project C++ đang làm việc.
 
##	Viết và biên dịch code C++ sử dụng Visual Studio Code
###	Mở project đang làm việc
-	Chạy command hoặc terminal (ubuntu) tại thư mục đang làm việc;
-	Chạy lệnh: `code .`
###	Compile code trong Visual Studio Code
1.	Tạo file tasks.json và thiết lập các option khi biên dịch
-  Chọn **Terminal -> configure Task -> C/C++:g++.exe build active file**
-  Sửa các thông tin trong file tasks.json, chú ý link đến thư  mục chứa thư viện mở rộng (-L) và file thư viện cần dùng (-l:). 
2. Windows 
```
{
    "version": "2.0.0",
    "tasks": [
        {
            "type": "shell",
            "label": "C/C++: g++.exe build active file",
            "command": "C:\\msys64\\mingw64\\bin\\g++.exe",
            "args": [
                "-g2",
                "-O3",
                "-DNDEBUG",
                "${file}",
                "-o",
                "${fileDirname}\\${fileBasenameNoExtension}.exe",
                "-D_WIN32_WINNT=0x0501",
                "-pthread",
                "-L${workspaceFolder}\\lib",
                "-l:libcryptopp.a",
                "-I${workspaceFolder}\\include",
                "-Wall"
            ],
            "options": {
                "cwd": "C:\\msys64\\mingw64\\bin"
            },
            "problemMatcher": [
                "$gcc"
            ],
            "group": {
                "kind": "build",
                "isDefault": true
            },
            "detail": "compiler: C:\\msys64\\mingw64\\bin\\g++.exe"
        }
    ]
}
```
3. Ubuntu  
```
{
    "version": "2.0.0",
    "tasks": [
        {
            "type": "shell",
            "label": "C/C++: g++ build active file",
            "command": "/usr/bin/g++",
            "args": [
                "-g2",
                "-O3",
                "-DNDEBUG",
                "${file}",
                "-o",
                "${fileDirname}/${fileBasenameNoExtension}",
                "-pthread",
                "-I${workspaceFolder}/include",
                "-L${workspaceFolder}/lib",
                "-l:libcryptopp.a",
                "-Wall"
            ],
            "options": {
                "cwd": "${workspaceFolder}"
            },
            "problemMatcher": [
                "$gcc"
            ],
            "group": "build",
            "detail": "compiler: /usr/bin/g++"
        }
    ]
}
```
4.	Biên dịch code
- Chọn **Terminal -> Run build task** để biên dịch code 









