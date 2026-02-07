```

BenchmarkDotNet v0.15.8, Linux Arch Linux
AMD Ryzen 9 5900X 1.73GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method                          | EntityCount | Mean        | Error     | StdDev    | Allocated |
|-------------------------------- |------------ |------------:|----------:|----------:|----------:|
| Frent_QueryInline               | 100000      |    25.91 μs |  0.410 μs |  0.384 μs |         - |
| HypEcs_MonoThread               | 100000      |    27.01 μs |  0.311 μs |  0.276 μs |     352 B |
| TinyEcs_Each                    | 100000      |    27.72 μs |  0.222 μs |  0.207 μs |         - |
| Myriad_SingleThreadChunk        | 100000      |    30.52 μs |  0.485 μs |  0.454 μs |         - |
| FrifloEngineEcs_MonoThread      | 100000      |    44.42 μs |  0.116 μs |  0.097 μs |         - |
| Arch_MonoThread_SourceGenerated | 100000      |    45.81 μs |  0.467 μs |  0.437 μs |         - |
| FlecsNet_Iter                   | 100000      |    48.16 μs |  0.190 μs |  0.159 μs |         - |
| Fennecs_ForEach                 | 100000      |    48.16 μs |  0.166 μs |  0.155 μs |         - |
| Arch                            | 100000      |    49.92 μs |  0.588 μs |  0.550 μs |         - |
| SveltoECS                       | 100000      |    51.24 μs |  0.279 μs |  0.261 μs |         - |
| Exanite                         | 100000      |    52.12 μs |  0.207 μs |  0.194 μs |         - |
| Fennecs_Raw                     | 100000      |    54.19 μs |  0.248 μs |  0.232 μs |         - |
| Myriad_SingleThread             | 100000      |    55.92 μs |  0.279 μs |  0.261 μs |         - |
| Myriad_Delegate                 | 100000      |    81.76 μs |  0.251 μs |  0.223 μs |         - |
| DefaultEcs_MonoThread           | 100000      |   123.28 μs |  0.418 μs |  0.391 μs |         - |
| Myriad_Enumerable               | 100000      |   145.90 μs |  0.438 μs |  0.388 μs |         - |
| LeopotamEcs                     | 100000      |   153.84 μs |  0.600 μs |  0.532 μs |         - |
| LeopotamEcsLite                 | 100000      |   185.80 μs |  0.998 μs |  0.933 μs |         - |
| FlecsNet_Each                   | 100000      |   213.77 μs |  2.151 μs |  2.012 μs |         - |
| MonoGameExtended                | 100000      |   333.25 μs |  2.598 μs |  2.430 μs |     160 B |
| RelEcs                          | 100000      |   364.88 μs |  2.817 μs |  2.635 μs |     448 B |
| Morpeh_Stash                    | 100000      |   962.69 μs | 13.915 μs | 12.336 μs |         - |
| Morpeh_Direct                   | 100000      | 1,443.73 μs | 28.184 μs | 35.644 μs |         - |
