```

BenchmarkDotNet v0.13.12, Arch Linux
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.125.57005), X64 RyuJIT AVX2
  Job-VUCTTL : .NET 10.0.1 (10.0.125.57005), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

```
| Method  | EntityCount | Mean     | Error    | StdDev   | Allocated |
|-------- |------------ |---------:|---------:|---------:|----------:|
| Exanite | 100000      | 28.67 ms | 0.554 ms | 0.569 ms |  16.54 MB |
