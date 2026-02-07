```

BenchmarkDotNet v0.15.8, Linux Arch Linux
AMD Ryzen 9 5900X 1.73GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method              | EntityCount | EntityPadding | Mean     | Error    | StdDev   | Code Size | Allocated |
|-------------------- |------------ |-------------- |---------:|---------:|---------:|----------:|----------:|
| Exanite             | 100000      | 0             | 23.23 μs | 0.252 μs | 0.210 μs |   2,098 B |         - |
| Frent_QueryInline   | 100000      | 0             | 24.73 μs | 0.213 μs | 0.189 μs |     117 B |         - |
| Frent_QueryDelegate | 100000      | 0             | 24.75 μs | 0.459 μs | 0.429 μs |     456 B |         - |
