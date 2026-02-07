```

BenchmarkDotNet v0.13.12, Arch Linux
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.125.57005), X64 RyuJIT AVX2
  DefaultJob : .NET 10.0.1 (10.0.125.57005), X64 RyuJIT AVX2


```
| Method  | EntityCount | EntityPadding | Mean     | Error    | StdDev   | Allocated |
|-------- |------------ |-------------- |---------:|---------:|---------:|----------:|
| Exanite | 100000      | 0             | 24.98 μs | 0.457 μs | 0.428 μs |         - |
