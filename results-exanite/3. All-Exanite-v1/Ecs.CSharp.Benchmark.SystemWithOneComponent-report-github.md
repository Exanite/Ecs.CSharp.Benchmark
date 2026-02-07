```

BenchmarkDotNet v0.15.8, Linux Arch Linux
AMD Ryzen 9 5900X 1.73GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method                                | EntityCount | EntityPadding | Mean      | Error     | StdDev   | Allocated |
|-------------------------------------- |------------ |-------------- |----------:|----------:|---------:|----------:|
| Fennecs_ForEach                       | 100000      | 0             |  22.09 μs |  0.124 μs | 0.110 μs |         - |
| DefaultEcs_ComponentSystem_MonoThread | 100000      | 0             |  22.66 μs |  0.446 μs | 0.458 μs |         - |
| HypEcs_MonoThread                     | 100000      | 0             |  23.83 μs |  0.108 μs | 0.096 μs |      72 B |
| Frent_QueryInline                     | 100000      | 0             |  23.88 μs |  0.183 μs | 0.171 μs |         - |
| Frent_QueryDelegate                   | 100000      | 0             |  23.92 μs |  0.083 μs | 0.070 μs |         - |
| Myriad_SingleThreadChunk              | 100000      | 0             |  24.61 μs |  0.209 μs | 0.196 μs |         - |
| Exanite                               | 100000      | 0             |  25.04 μs |  0.285 μs | 0.238 μs |         - |
| TinyEcs_Each                          | 100000      | 0             |  29.69 μs |  0.185 μs | 0.173 μs |         - |
| SveltoECS                             | 100000      | 0             |  39.62 μs |  0.206 μs | 0.193 μs |         - |
| Fennecs_Raw                           | 100000      | 0             |  40.41 μs |  0.100 μs | 0.083 μs |         - |
| FrifloEngineEcs_MonoThread            | 100000      | 0             |  44.22 μs |  0.131 μs | 0.116 μs |         - |
| FlecsNet_Iter                         | 100000      | 0             |  47.69 μs |  0.201 μs | 0.188 μs |         - |
| Myriad_SingleThread                   | 100000      | 0             |  48.65 μs |  0.268 μs | 0.237 μs |         - |
| Arch_MonoThread_SourceGenerated       | 100000      | 0             |  54.85 μs |  0.123 μs | 0.103 μs |         - |
| Arch_MonoThread                       | 100000      | 0             |  55.28 μs |  0.216 μs | 0.202 μs |         - |
| FlecsNet_Each                         | 100000      | 0             |  74.34 μs |  0.527 μs | 0.493 μs |         - |
| Myriad_Delegate                       | 100000      | 0             |  89.12 μs |  0.384 μs | 0.359 μs |         - |
| DefaultEcs_EntitySetSystem_MonoThread | 100000      | 0             |  89.25 μs |  0.466 μs | 0.413 μs |         - |
| LeopotamEcs                           | 100000      | 0             |  99.96 μs |  0.356 μs | 0.333 μs |         - |
| RelEcs                                | 100000      | 0             | 115.00 μs |  1.031 μs | 0.805 μs |      72 B |
| LeopotamEcsLite                       | 100000      | 0             | 119.43 μs |  0.358 μs | 0.335 μs |         - |
| Myriad_Enumerable                     | 100000      | 0             | 123.98 μs |  0.592 μs | 0.495 μs |         - |
| MonoGameExtended                      | 100000      | 0             | 294.19 μs |  1.416 μs | 1.324 μs |     160 B |
| Morpeh_Stash                          | 100000      | 0             | 602.77 μs |  7.258 μs | 6.061 μs |         - |
| Morpeh_Direct                         | 100000      | 0             | 996.11 μs | 10.586 μs | 8.265 μs |         - |
