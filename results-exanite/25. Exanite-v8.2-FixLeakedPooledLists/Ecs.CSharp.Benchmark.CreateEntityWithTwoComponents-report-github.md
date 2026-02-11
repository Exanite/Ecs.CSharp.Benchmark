```

BenchmarkDotNet v0.15.8, Linux Arch Linux
AMD Ryzen 9 5900X 1.73GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  Job-CNUJVU : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3

InvocationCount=1  UnrollFactor=1  

```
| Method  | EntityCount | Mean     | Error    | StdDev   | Median   | Allocated |
|-------- |------------ |---------:|---------:|---------:|---------:|----------:|
| Exanite | 100000      | 28.23 ms | 0.651 ms | 1.846 ms | 27.57 ms |  17.66 MB |
