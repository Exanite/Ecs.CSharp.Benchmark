```

BenchmarkDotNet v0.15.8, Linux Arch Linux
AMD Ryzen 9 5900X 1.73GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method  | EntityCount | EntityPadding | Mean     | Error    | StdDev   | Code Size | Allocated |
|-------- |------------ |-------------- |---------:|---------:|---------:|----------:|----------:|
| Exanite | 100000      | 0             | 27.66 μs | 0.335 μs | 0.313 μs |   2,190 B |         - |
