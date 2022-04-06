# C vs Rust vs Other Languages Benchmark

### Test01 : Hello world : First and second compile time
```
gcc         0m0,085s    0m0,035s
rust        0m0,499s    0m0,222s
go          0m0,313s    0m0,067s
mono        0m0,216s    0m0,186s
ms dotnet   0m3,140s    0m1,596s
openjdk     0m0,583s    0m0,485s
oraclejdk   0m0,595s    0m0,482s
```
### Test01 : Hello world : File size in bytes
```
gcc                       16696
gcc (stripped)            14472
rust                    3585800
rust (stripped)          309568
go                      1754233
go (stripped)           1176344
mono                       3072
ms dotnet                147624
ms dotnet (stripped)     142632 (don't strip, file corrupted !!!)
openjdk                     418
oraclejdk                   418
php                          35
```
### Test01 : Hello world : First and second run time
```
gcc         0m0,001s    0m0,001s
rust        0m0,002s    0m0,001s
go          0m0,003s    0m0,001s
mono        0m0,032s    0m0,024s
ms dotnet   0m0,110s    0m0,060s
openjdk     0m0,103s    0m0,044s
oraclejdk   0m0,094s    0m0,044s
php         0m0,010s    0m0,009s
```
### Test02 : Hello world : Memory usage (Private + Shared = Total)
```
gcc          96.0 KiB +  10.5 KiB = 106.5 KiB
rust        428.0 KiB +  14.5 KiB = 442.5 KiB
go            1.7 MiB +   0.5 KiB =   1.7 MiB
mono         14.4 MiB +  56.5 KiB =  14.5 MiB
ms dotnet     4.3 MiB +   8.1 MiB =  12.4 MiB
openjdk      35.4 MiB +  89.5 KiB =  35.5 MiB
oraclejdk    35.3 MiB +  39.5 KiB =  35.4 MiB
php           8.3 MiB + 964.5 KiB =   9.3 MiB
```
### Test03 : Inner loops and calculation (optimizations possible) : run time
```
gcc         0m1,800s
gcc -O1     0m0,242s
gcc -O2     0m0,001s
rust        0m16,970s
go          0m0,484s
mono        0m0,827s
ms dotnet   0m0,543s
openjdk     0m0,419s
oraclejdk   0m0,417s
php         0m13,152s
```
### Test04 : Inner loops and calculation (optimizations hard) : run time
```
```
