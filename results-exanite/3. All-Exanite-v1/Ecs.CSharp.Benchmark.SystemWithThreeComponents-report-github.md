```

BenchmarkDotNet v0.15.8, Linux Arch Linux
AMD Ryzen 9 5900X 1.73GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method                          | EntityCount | EntityPadding | Mean        | Error     | StdDev    | Allocated |
|-------------------------------- |------------ |-------------- |------------:|----------:|----------:|----------:|
| TinyEcs_Each                    | 100000      | 0             |    43.55 μs |  0.355 μs |  0.332 μs |         - |
| Frent_QueryInline               | 100000      | 0             |    43.75 μs |  0.471 μs |  0.440 μs |         - |
| HypEcs_MonoThread               | 100000      | 0             |    45.41 μs |  0.583 μs |  0.546 μs |     152 B |
| Frent_QueryDelegate             | 100000      | 0             |    46.08 μs |  0.403 μs |  0.357 μs |         - |
| Myriad_SingleThreadChunk        | 100000      | 0             |    49.31 μs |  0.476 μs |  0.422 μs |         - |
| Fennecs_Raw                     | 100000      | 0             |    49.59 μs |  0.592 μs |  0.553 μs |         - |
| SveltoECS                       | 100000      | 0             |    50.01 μs |  0.668 μs |  0.625 μs |         - |
| FrifloEngineEcs_MonoThread      | 100000      | 0             |    53.85 μs |  0.398 μs |  0.373 μs |         - |
| Myriad_SingleThread             | 100000      | 0             |    54.04 μs |  0.479 μs |  0.448 μs |         - |
| Arch_MonoThread                 | 100000      | 0             |    54.85 μs |  0.954 μs |  0.892 μs |         - |
| Arch_MonoThread_SourceGenerated | 100000      | 0             |    62.37 μs |  0.835 μs |  0.781 μs |         - |
| Fennecs_ForEach                 | 100000      | 0             |    70.02 μs |  0.902 μs |  0.844 μs |         - |
| Exanite                         | 100000      | 0             |    76.98 μs |  0.685 μs |  0.641 μs |         - |
| FlecsNet_Iter                   | 100000      | 0             |    81.38 μs |  0.285 μs |  0.266 μs |         - |
| Myriad_Delegate                 | 100000      | 0             |    89.27 μs |  0.390 μs |  0.365 μs |         - |
| Myriad_Enumerable               | 100000      | 0             |   179.40 μs |  0.773 μs |  0.723 μs |         - |
| DefaultEcs_MonoThread           | 100000      | 0             |   184.87 μs |  0.627 μs |  0.587 μs |         - |
| LeopotamEcs                     | 100000      | 0             |   202.30 μs |  0.745 μs |  0.696 μs |         - |
| FlecsNet_Each                   | 100000      | 0             |   215.26 μs |  4.125 μs |  4.051 μs |         - |
| LeopotamEcsLite                 | 100000      | 0             |   256.28 μs |  0.876 μs |  0.777 μs |         - |
| RelEcs                          | 100000      | 0             |   301.78 μs |  2.756 μs |  2.578 μs |     216 B |
| MonoGameExtended                | 100000      | 0             |   434.44 μs |  1.775 μs |  1.660 μs |     160 B |
| Morpeh_Stash                    | 100000      | 0             |   811.61 μs | 13.800 μs | 12.908 μs |         - |
| Morpeh_Direct                   | 100000      | 0             | 1,855.28 μs | 14.373 μs | 13.445 μs |         - |
