```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3593/23H2/2023Update/SunValley3)
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.204
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```
| Method           | input       | Mean       | Error     | StdDev    | Gen0   | Allocated |
|----------------- |------------ |-----------:|----------:|----------:|-------:|----------:|
| **ReverseLinQ**      | ****            |  **27.428 ns** | **0.6064 ns** | **0.8697 ns** | **0.0191** |      **80 B** |
| Reverse          |             |  10.841 ns | 0.1120 ns | 0.0936 ns | 0.0249 |     104 B |
| ReverseCharArray |             |   2.866 ns | 0.0185 ns | 0.0144 ns |      - |         - |
| **ReverseLinQ**      | **I&#39;m hungry!** | **140.659 ns** | **0.3349 ns** | **0.2614 ns** | **0.0687** |     **288 B** |
| Reverse          | I&#39;m hungry! |  37.543 ns | 0.1558 ns | 0.1301 ns | 0.0363 |     152 B |
| ReverseCharArray | I&#39;m hungry! |  25.347 ns | 0.1971 ns | 0.1748 ns | 0.0229 |      96 B |
| **ReverseLinQ**      | **racecar**     | **106.274 ns** | **1.0478 ns** | **0.9801 ns** | **0.0554** |     **232 B** |
| Reverse          | racecar     |  29.746 ns | 0.2604 ns | 0.2308 ns | 0.0344 |     144 B |
| ReverseCharArray | racecar     |  22.841 ns | 0.1301 ns | 0.1154 ns | 0.0191 |      80 B |
| **ReverseLinQ**      | **robot**       | **101.953 ns** | **0.5743 ns** | **0.4796 ns** | **0.0535** |     **224 B** |
| Reverse          | robot       |  26.881 ns | 0.5877 ns | 0.8615 ns | 0.0325 |     136 B |
| ReverseCharArray | robot       |  22.141 ns | 0.1231 ns | 0.1028 ns | 0.0172 |      72 B |
