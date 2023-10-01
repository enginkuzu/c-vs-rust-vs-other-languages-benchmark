# C vs Rust vs Other Languages Benchmark

### Test01 : Hello world : First and second compile time
```
gcc         0m0,085s    0m0,035s
clang       0m0,207s    0m0,086s
rust        0m0,499s    0m0,222s
go          0m0,313s    0m0,067s
gccgo       0m0,179s    0m0,135s
mono        0m0,216s    0m0,186s
ms dotnet   0m3,140s    0m1,596s
openjdk     0m0,583s    0m0,485s
oraclejdk   0m0,595s    0m0,482s
crystal     0m0.753s    0m0.502s
erlang      0m0.166s    0m0.164s
zig         0m1.034s    0m0.893s
```
### Test01 : Hello world : File size in bytes
```
gcc                            16696
gcc (stripped)                 14472
clang                          16456
clang (stripped)               14384
rust                         3585800
rust (stripped)               309568
go                           1754233
go (stripped)                1176344
gccgo                          51360
gccgo (stripped)               36520
mono                            3072
ms dotnet                     147624
ms dotnet (stripped)          142632 (file corrupted !!!)
openjdk                          418
oraclejdk                        418
php                               35
crystal                       615776
crystal (stripped)            216096
erlang                           744
zig (Debug)                  1897552
zig (Debug, stripped)         598624
zig (ReleaseSafe)            1944776
zig (ReleaseSafe, stripped)   228320
zig (ReleaseSmall)              8856
zig (ReleaseSmall, stripped)    7816
zig (ReleaseFast)            1710376
zig (ReleaseFast, stripped)   170800
```
### Test01 : Hello world : First and second execution time
```
gcc         0m0,001s    0m0,001s
clang       0m0,001s    0m0,001s
rust        0m0,002s    0m0,001s
go          0m0,003s    0m0,001s
gccgo       0m0,030s    0m0,015s
mono        0m0,032s    0m0,024s
ms dotnet   0m0,110s    0m0,060s
openjdk     0m0,103s    0m0,044s
oraclejdk   0m0,094s    0m0,044s
php         0m0,010s    0m0,009s
crystal     0m0.005s    0m0.005s
erlang      0m1.101s    0m1.101s
zig         0m0.004s    0m0.002s
```
### Test02 : Hello world : Memory usage (Private + Shared = Total)
```
gcc          96.0 KiB +  10.5 KiB = 106.5 KiB
clang        92.0 KiB +  11.5 KiB = 103.5 KiB
rust        428.0 KiB +  14.5 KiB = 442.5 KiB
go            1.7 MiB +   0.5 KiB =   1.7 MiB
gccgo        19.2 MiB +  29.5 KiB =  19.2 MiB
mono         14.4 MiB +  56.5 KiB =  14.5 MiB
ms dotnet     4.3 MiB +   8.1 MiB =  12.4 MiB
openjdk      35.4 MiB +  89.5 KiB =  35.5 MiB
oraclejdk    35.3 MiB +  39.5 KiB =  35.4 MiB
php           8.3 MiB + 964.5 KiB =   9.3 MiB
crystal     996.0 KiB +  19.5 KiB =   1.0 MiB
```
### Test03 : Inner loops and calculation (optimizations possible) : Execution time
```
gcc                  0m1,800s
gcc -O1              0m0,242s
gcc -O2              0m0,001s
clang                0m1,794s
clang -O1            0m0,001s
rust                 0m16,970s
rust -C opt-level=1  0m1,240s
rust -C opt-level=2  0m0,001s
go                   0m0,484s
gccgo                0m1,794s
gccgo -O1            0m0,257s
gccgo -O2            0m0,015s
mono                 0m0,827s
ms dotnet            0m0,543s
openjdk              0m0,419s
oraclejdk            0m0,417s
php                  0m13,152s
```
### Test04 : Inner loops and calculation (optimizations hard) : Execution time
```
gcc                  0m1,963s
gcc -O1              0m0,242s
gcc -O2              0m0,242s
gcc -O3              0m0,197s
clang                0m1,782s
clang -O1            0m0,001s
rust                 0m17,657s
rust -C opt-level=1  0m1,021s
rust -C opt-level=2  0m0,001s
go                   0m0,484s
gccgo                0m1,739s
gccgo -O1            0m0,256s
gccgo -O2            0m0,015s
mono                 0m0,991s
ms dotnet            0m0,530s
openjdk              0m0,423s
oraclejdk            0m0,421s
php                  0m13,146s
```
### Test05 : Inner loops and calculation (optimizations not possible) : Execution time
```
gcc                  0m1,944s
gcc -O1              0m0,242s
gcc -O2              0m0,242s
gcc -O3              0m0,197s
clang                0m1,784s
clang -O1            0m0,242s
clang -O2            0m0,242s
clang -O3            0m0,242s
rust                 0m17,535s
rust -C opt-level=1  0m1,246s
rust -C opt-level=2  0m0,242s
rust -C opt-level=3  0m0,242s
go                   0m0,484s
gccgo                0m1,717s
gccgo -O1            0m0,257s
gccgo -O2            0m0,498s
gccgo -O3            0m0,212s
mono                 0m0,990s
ms dotnet            0m0,550s
openjdk              0m0,424s
oraclejdk            0m0,424s
php                  0m13,146s
```
### Test06 : HashMap put and get operations : Execution times
```
gcc                  1170 ms     340 ms
rust                 31253 ms    15862 ms
rust -C opt-level=1  3206 ms     2885 ms
rust -C opt-level=2  3031 ms     2762 ms
go                   4394 ms     1837 ms
gccgo                4959 ms     2799 ms
mono                 1404 ms     477 ms
ms dotnet            1023 ms     208 ms
openjdk              1804 ms     445 ms
oraclejdk            1777 ms     432 ms
php                  1187 ms     432 ms
```
### Test06 : HashMap put operation : Memory usage (Private + Shared = Total)
```
gcc         384.3 MiB +  24.5 KiB = 384.3 MiB
rust        288.5 MiB +  20.5 KiB = 288.5 MiB
go          707.3 MiB +   0.5 KiB = 707.3 MiB
gccgo       737.9 MiB +  33.5 KiB = 737.9 MiB
mono          1.2 GiB +  78.5 KiB =   1.2 GiB
ms dotnet   959.2 MiB +   1.0 MiB = 960.2 MiB
openjdk       2.2 GiB + 105.5 KiB =   2.2 GiB
oraclejdk     2.1 GiB +  51.5 KiB =   2.1 GiB
php         772.4 MiB +   1.1 MiB = 773.5 MiB
```
