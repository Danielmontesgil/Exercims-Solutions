```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3593/23H2/2023Update/SunValley3)
AMD Ryzen 7 2700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.204
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```
| Method     | statement | Mean     | Error    | StdDev   | Gen0   | Allocated |
|----------- |---------- |---------:|---------:|---------:|-------:|----------:|
| MyApproach | message   | 30.24 ns | 0.508 ns | 0.475 ns | 0.0095 |      40 B |
| Response   | message   | 43.54 ns | 0.882 ns | 0.866 ns | 0.0172 |      72 B |
