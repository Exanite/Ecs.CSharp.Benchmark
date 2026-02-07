```

BenchmarkDotNet v0.15.8, Linux Arch Linux
AMD Ryzen 9 5900X 1.73GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method            | EntityCount | Mean     | Error    | StdDev   | Code Size | Allocated |
|------------------ |------------ |---------:|---------:|---------:|----------:|----------:|
| Frent_QueryInline | 100000      | 27.12 μs | 0.504 μs | 0.447 μs |     157 B |         - |
| Exanite           | 100000      | 45.88 μs | 0.553 μs | 0.490 μs |     508 B |         - |
