```

BenchmarkDotNet v0.15.8, Linux Arch Linux
AMD Ryzen 9 5900X 1.73GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method                          | EntityCount | EntityPadding | Mean        | Error     | StdDev    | Allocated |
|-------------------------------- |------------ |-------------- |------------:|----------:|----------:|----------:|
| Frent_QueryDelegate             | 100000      | 0             |    25.38 μs |  0.443 μs |  0.414 μs |         - |
| Frent_QueryInline               | 100000      | 0             |    26.05 μs |  0.482 μs |  0.451 μs |         - |
| HypEcs_MonoThread               | 100000      | 0             |    26.11 μs |  0.450 μs |  0.421 μs |     112 B |
| TinyEcs_Each                    | 100000      | 0             |    27.70 μs |  0.243 μs |  0.227 μs |         - |
| Myriad_SingleThreadChunk        | 100000      | 0             |    31.22 μs |  0.607 μs |  0.650 μs |         - |
| FrifloEngineEcs_MonoThread      | 100000      | 0             |    44.24 μs |  0.213 μs |  0.199 μs |         - |
| Fennecs_ForEach                 | 100000      | 0             |    47.66 μs |  0.215 μs |  0.201 μs |         - |
| SveltoECS                       | 100000      | 0             |    48.56 μs |  0.234 μs |  0.207 μs |         - |
| FlecsNet_Iter                   | 100000      | 0             |    49.56 μs |  0.336 μs |  0.314 μs |         - |
| Arch_MonoThread                 | 100000      | 0             |    50.04 μs |  0.491 μs |  0.410 μs |         - |
| Arch_MonoThread_SourceGenerated | 100000      | 0             |    50.38 μs |  0.184 μs |  0.173 μs |         - |
| Exanite                         | 100000      | 0             |    51.12 μs |  0.088 μs |  0.078 μs |         - |
| Fennecs_Raw                     | 100000      | 0             |    52.78 μs |  0.098 μs |  0.092 μs |         - |
| Myriad_SingleThread             | 100000      | 0             |    56.36 μs |  0.638 μs |  0.597 μs |         - |
| Myriad_Delegate                 | 100000      | 0             |    81.63 μs |  0.482 μs |  0.451 μs |         - |
| DefaultEcs_MonoThread           | 100000      | 0             |   122.84 μs |  0.462 μs |  0.432 μs |         - |
| Myriad_Enumerable               | 100000      | 0             |   152.27 μs |  1.478 μs |  1.234 μs |         - |
| LeopotamEcs                     | 100000      | 0             |   153.34 μs |  0.538 μs |  0.503 μs |         - |
| LeopotamEcsLite                 | 100000      | 0             |   184.62 μs |  0.727 μs |  0.680 μs |         - |
| FlecsNet_Each                   | 100000      | 0             |   188.32 μs |  3.741 μs |  7.471 μs |         - |
| RelEcs                          | 100000      | 0             |   246.10 μs |  1.950 μs |  1.824 μs |     168 B |
| MonoGameExtended                | 100000      | 0             |   359.71 μs |  2.232 μs |  1.979 μs |     160 B |
| Morpeh_Stash                    | 100000      | 0             |   740.30 μs | 14.549 μs | 25.097 μs |         - |
| Morpeh_Direct                   | 100000      | 0             | 1,283.32 μs |  6.628 μs |  5.175 μs |         - |
