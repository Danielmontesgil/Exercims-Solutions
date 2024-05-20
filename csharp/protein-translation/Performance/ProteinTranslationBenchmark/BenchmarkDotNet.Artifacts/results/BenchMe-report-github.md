```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3593/23H2/2023Update/SunValley3)
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.204
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```
| Method       | strand             | Mean      | Error    | StdDev    | Gen0   | Allocated |
|------------- |------------------- |----------:|---------:|----------:|-------:|----------:|
| **Proteins**     | **AUGUUUUAA**          |  **57.05 ns** | **1.189 ns** |  **1.461 ns** | **0.0535** |     **224 B** |
| LinQApproach | AUGUUUUAA          | 422.31 ns | 8.230 ns | 11.537 ns | 0.1988 |     832 B |
| **Proteins**     | **UGGUAG**             |  **45.53 ns** | **0.285 ns** |  **0.238 ns** | **0.0440** |     **184 B** |
| LinQApproach | UGGUAG             | 334.23 ns | 3.204 ns |  2.841 ns | 0.1740 |     728 B |
| **Proteins**     | **UGGUAGUGG**          |  **45.40 ns** | **0.320 ns** |  **0.299 ns** | **0.0440** |     **184 B** |
| LinQApproach | UGGUAGUGG          | 329.57 ns | 0.855 ns |  0.668 ns | 0.1740 |     728 B |
| **Proteins**     | **UGGUGUUAUUAAUGGUUU** |  **68.57 ns** | **0.819 ns** |  **0.684 ns** | **0.0631** |     **264 B** |
| LinQApproach | UGGUGUUAUUAAUGGUUU | 510.29 ns | 4.986 ns |  4.164 ns | 0.2232 |     936 B |
