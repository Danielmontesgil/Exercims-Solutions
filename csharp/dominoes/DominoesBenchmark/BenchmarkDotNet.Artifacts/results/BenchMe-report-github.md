```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3593/23H2/2023Update/SunValley3)
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.204
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```
| Method     | dominoes             | Mean        | Error     | StdDev    | Gen0   | Allocated |
|----------- |--------------------- |------------:|----------:|----------:|-------:|----------:|
| **CanChain**   | **Value(...)2&gt;[2] [27]** |    **74.25 ns** |  **1.155 ns** |  **1.080 ns** | **0.0343** |     **144 B** |
| MyApproach | Value(...)2&gt;[2] [27] |    71.39 ns |  1.459 ns |  2.631 ns | 0.0248 |     104 B |
| **CanChain**   | **Value(...)2&gt;[5] [27]** |   **654.27 ns** |  **9.675 ns** |  **9.050 ns** | **0.2861** |    **1200 B** |
| MyApproach | Value(...)2&gt;[5] [27] |   673.34 ns | 13.277 ns | 21.815 ns | 0.2937 |    1232 B |
| **CanChain**   | **Value(...)2&gt;[6] [27]** |   **682.90 ns** | **13.316 ns** | **15.335 ns** | **0.2766** |    **1160 B** |
| MyApproach | Value(...)2&gt;[6] [27] |   468.67 ns |  2.590 ns |  2.296 ns | 0.1965 |     824 B |
| **CanChain**   | **Value(...)2&gt;[9] [27]** | **2,029.70 ns** | **34.564 ns** | **30.640 ns** | **0.9384** |    **3928 B** |
| MyApproach | Value(...)2&gt;[9] [27] | 1,618.91 ns | 25.945 ns | 22.999 ns | 0.6542 |    2736 B |
