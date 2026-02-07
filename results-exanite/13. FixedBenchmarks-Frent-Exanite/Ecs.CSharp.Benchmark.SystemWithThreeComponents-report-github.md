```

BenchmarkDotNet v0.15.8, Linux Arch Linux
AMD Ryzen 9 5900X 1.73GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method              | EntityCount | EntityPadding | Mean     | Error    | StdDev   | Code Size | Allocated |
|-------------------- |------------ |-------------- |---------:|---------:|---------:|----------:|----------:|
| Frent_QueryInline   | 100000      | 0             | 46.17 μs | 0.403 μs | 0.377 μs |     217 B |         - |
| Frent_QueryDelegate | 100000      | 0             | 48.66 μs | 0.566 μs | 0.529 μs |     663 B |         - |
| Exanite             | 100000      | 0             | 56.65 μs | 0.196 μs | 0.174 μs |     579 B |         - |
