```

BenchmarkDotNet v0.15.8, Linux Arch Linux
AMD Ryzen 9 5900X 1.73GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method              | EntityCount | EntityPadding | Mean     | Error    | StdDev   | Code Size | Allocated |
|-------------------- |------------ |-------------- |---------:|---------:|---------:|----------:|----------:|
| Frent_QueryDelegate | 100000      | 0             | 27.15 μs | 0.381 μs | 0.356 μs |     538 B |         - |
| Frent_QueryInline   | 100000      | 0             | 27.21 μs | 0.326 μs | 0.305 μs |     157 B |         - |
| Exanite             | 100000      | 0             | 45.46 μs | 0.320 μs | 0.267 μs |     508 B |         - |
