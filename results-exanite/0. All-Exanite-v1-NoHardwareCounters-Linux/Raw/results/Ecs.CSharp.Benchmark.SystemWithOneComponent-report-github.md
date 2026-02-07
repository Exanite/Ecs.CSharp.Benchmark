```

BenchmarkDotNet v0.13.12, Arch Linux
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.125.57005), X64 RyuJIT AVX2
  DefaultJob : .NET 10.0.1 (10.0.125.57005), X64 RyuJIT AVX2


```
| Method                                 | EntityCount | EntityPadding | Mean         | Error      | StdDev      | Median       | Gen0   | Gen1   | Allocated |
|--------------------------------------- |------------ |-------------- |-------------:|-----------:|------------:|-------------:|-------:|-------:|----------:|
| FrifloEngineEcs_SIMD_MonoThread        | 100000      | 0             |     7.783 μs |  0.0550 μs |   0.0488 μs |     7.772 μs |      - |      - |         - |
| Frent_Simd                             | 100000      | 10            |     7.956 μs |  0.0257 μs |   0.0228 μs |     7.957 μs |      - |      - |         - |
| Frent_Simd                             | 100000      | 0             |     8.092 μs |  0.0214 μs |   0.0189 μs |     8.099 μs |      - |      - |         - |
| Myriad_SingleThreadChunk_SIMD          | 100000      | 10            |     8.117 μs |  0.1621 μs |   0.2164 μs |     8.160 μs |      - |      - |         - |
| FrifloEngineEcs_SIMD_MonoThread        | 100000      | 10            |     8.228 μs |  0.1707 μs |   0.4758 μs |     8.229 μs |      - |      - |         - |
| Myriad_SingleThreadChunk_SIMD          | 100000      | 0             |     9.262 μs |  0.3823 μs |   1.1273 μs |     8.509 μs |      - |      - |         - |
| FrifloEngineEcs_MultiThread            | 100000      | 0             |    10.665 μs |  0.7150 μs |   2.0744 μs |    10.377 μs |      - |      - |         - |
| FrifloEngineEcs_MultiThread            | 100000      | 10            |    11.090 μs |  0.7555 μs |   2.2039 μs |    10.865 μs |      - |      - |         - |
| TinyEcs_EachJob                        | 100000      | 10            |    15.670 μs |  0.1136 μs |   0.2020 μs |    15.687 μs | 0.0916 |      - |    1552 B |
| TinyEcs_EachJob                        | 100000      | 0             |    19.469 μs |  0.3872 μs |   0.5428 μs |    19.308 μs | 0.0916 |      - |    1552 B |
| DefaultEcs_ComponentSystem_MonoThread  | 100000      | 10            |    22.782 μs |  0.1102 μs |   0.1031 μs |    22.769 μs |      - |      - |         - |
| Fennecs_ForEach                        | 100000      | 0             |    22.967 μs |  0.1517 μs |   0.1345 μs |    22.969 μs |      - |      - |         - |
| DefaultEcs_ComponentSystem_MonoThread  | 100000      | 0             |    23.065 μs |  0.1899 μs |   0.1585 μs |    23.083 μs |      - |      - |         - |
| Frent_QueryDelegate                    | 100000      | 0             |    24.072 μs |  0.0625 μs |   0.0554 μs |    24.055 μs |      - |      - |         - |
| Frent_QueryDelegate                    | 100000      | 10            |    24.130 μs |  0.0917 μs |   0.0766 μs |    24.116 μs |      - |      - |         - |
| Frent_QueryInline                      | 100000      | 0             |    24.196 μs |  0.1442 μs |   0.1278 μs |    24.214 μs |      - |      - |         - |
| Fennecs_ForEach                        | 100000      | 10            |    24.271 μs |  0.3189 μs |   0.7702 μs |    24.260 μs |      - |      - |         - |
| Frent_QueryInline                      | 100000      | 10            |    24.396 μs |  0.2164 μs |   0.2024 μs |    24.296 μs |      - |      - |         - |
| HypEcs_MonoThread                      | 100000      | 10            |    24.883 μs |  0.4728 μs |   0.5807 μs |    24.716 μs |      - |      - |      72 B |
| HypEcs_MultiThread                     | 100000      | 10            |    25.413 μs |  0.3794 μs |   0.3549 μs |    25.286 μs | 0.0610 |      - |    1832 B |
| Myriad_SingleThreadChunk               | 100000      | 10            |    25.673 μs |  0.4771 μs |   0.4463 μs |    25.692 μs |      - |      - |         - |
| Exanite                                | 100000      | 10            |    26.040 μs |  0.3471 μs |   0.3247 μs |    26.014 μs |      - |      - |         - |
| Exanite                                | 100000      | 0             |    26.265 μs |  0.4097 μs |   0.3832 μs |    26.059 μs |      - |      - |         - |
| HypEcs_MonoThread                      | 100000      | 0             |    27.159 μs |  1.1617 μs |   3.4254 μs |    24.982 μs |      - |      - |      72 B |
| DefaultEcs_ComponentSystem_MultiThread | 100000      | 0             |    27.454 μs |  1.6675 μs |   4.8906 μs |    26.800 μs |      - |      - |         - |
| Myriad_MultiThreadChunk                | 100000      | 10            |    27.991 μs |  0.3116 μs |   0.2915 μs |    28.024 μs | 1.2817 | 0.0610 |   21504 B |
| HypEcs_MultiThread                     | 100000      | 0             |    31.082 μs |  1.3765 μs |   4.0587 μs |    28.257 μs | 0.0610 |      - |    1833 B |
| TinyEcs_Each                           | 100000      | 10            |    32.292 μs |  0.2653 μs |   0.2481 μs |    32.232 μs |      - |      - |         - |
| Myriad_MultiThreadChunk                | 100000      | 0             |    34.286 μs |  0.4551 μs |   0.4257 μs |    34.249 μs | 1.2817 | 0.0916 |   21504 B |
| TinyEcs_Each                           | 100000      | 0             |    35.084 μs |  0.5018 μs |   0.4694 μs |    34.946 μs |      - |      - |         - |
| Myriad_SingleThreadChunk               | 100000      | 0             |    36.358 μs |  0.2975 μs |   0.2783 μs |    36.393 μs |      - |      - |         - |
| Fennecs_Job                            | 100000      | 0             |    39.072 μs |  0.6987 μs |   0.6535 μs |    39.161 μs |      - |      - |         - |
| FrifloEngineEcs_MonoThread             | 100000      | 0             |    40.287 μs |  0.1401 μs |   0.1310 μs |    40.272 μs |      - |      - |         - |
| Fennecs_Job                            | 100000      | 10            |    41.071 μs |  0.6504 μs |   0.7987 μs |    41.387 μs |      - |      - |         - |
| Fennecs_Raw                            | 100000      | 0             |    42.848 μs |  0.1717 μs |   0.1434 μs |    42.860 μs |      - |      - |         - |
| DefaultEcs_ComponentSystem_MultiThread | 100000      | 10            |    42.915 μs |  6.5230 μs |  18.7158 μs |    41.058 μs |      - |      - |         - |
| Fennecs_Raw                            | 100000      | 10            |    43.014 μs |  0.4827 μs |   1.0391 μs |    42.944 μs |      - |      - |         - |
| SveltoECS                              | 100000      | 10            |    43.216 μs |  0.6116 μs |   0.7511 μs |    43.204 μs |      - |      - |         - |
| FrifloEngineEcs_MonoThread             | 100000      | 10            |    45.055 μs |  0.2934 μs |   0.2601 μs |    45.098 μs |      - |      - |         - |
| FlecsNet_Iter                          | 100000      | 10            |    48.351 μs |  0.1372 μs |   0.1284 μs |    48.378 μs |      - |      - |         - |
| FlecsNet_Iter                          | 100000      | 0             |    48.643 μs |  0.1293 μs |   0.1210 μs |    48.580 μs |      - |      - |         - |
| SveltoECS                              | 100000      | 0             |    50.389 μs |  0.5219 μs |   0.4881 μs |    50.331 μs |      - |      - |         - |
| Myriad_SingleThread                    | 100000      | 10            |    54.556 μs |  0.5677 μs |   0.5310 μs |    54.357 μs |      - |      - |         - |
| Arch_MonoThread_SourceGenerated        | 100000      | 10            |    55.081 μs |  0.2228 μs |   0.2085 μs |    55.043 μs |      - |      - |         - |
| Arch_MonoThread_SourceGenerated        | 100000      | 0             |    55.335 μs |  0.1183 μs |   0.0988 μs |    55.352 μs |      - |      - |         - |
| Arch_MonoThread                        | 100000      | 10            |    55.722 μs |  0.1352 μs |   0.1199 μs |    55.709 μs |      - |      - |         - |
| Arch_MonoThread                        | 100000      | 0             |    55.991 μs |  0.2761 μs |   0.2583 μs |    55.889 μs |      - |      - |         - |
| Arch_MultiThread                       | 100000      | 0             |    57.006 μs |  0.7434 μs |   0.6954 μs |    57.152 μs |      - |      - |         - |
| Arch_MultiThread                       | 100000      | 10            |    58.739 μs |  0.8289 μs |   0.7754 μs |    58.778 μs |      - |      - |         - |
| Myriad_SingleThread                    | 100000      | 0             |    64.151 μs |  0.6746 μs |   0.6310 μs |    64.055 μs |      - |      - |         - |
| FlecsNet_Each                          | 100000      | 10            |    75.152 μs |  0.4820 μs |   0.4509 μs |    75.065 μs |      - |      - |         - |
| FlecsNet_Each                          | 100000      | 0             |    76.198 μs |  0.5463 μs |   0.4842 μs |    76.034 μs |      - |      - |         - |
| DefaultEcs_EntitySetSystem_MultiThread | 100000      | 0             |    77.009 μs |  7.7550 μs |  22.2506 μs |    74.003 μs |      - |      - |         - |
| Myriad_Delegate                        | 100000      | 10            |    90.553 μs |  0.7483 μs |   0.6999 μs |    90.472 μs |      - |      - |         - |
| DefaultEcs_EntitySetSystem_MultiThread | 100000      | 10            |    93.751 μs | 10.8228 μs |  31.3988 μs |    88.961 μs |      - |      - |         - |
| DefaultEcs_EntitySetSystem_MonoThread  | 100000      | 0             |    98.074 μs |  0.8432 μs |   0.7888 μs |    98.036 μs |      - |      - |         - |
| DefaultEcs_EntitySetSystem_MonoThread  | 100000      | 10            |   101.417 μs |  1.7512 μs |   1.6381 μs |   101.615 μs |      - |      - |         - |
| LeopotamEcs                            | 100000      | 10            |   104.515 μs |  0.8601 μs |   0.8045 μs |   104.444 μs |      - |      - |         - |
| Myriad_Delegate                        | 100000      | 0             |   111.893 μs |  0.5404 μs |   0.4790 μs |   111.885 μs |      - |      - |         - |
| LeopotamEcs                            | 100000      | 0             |   115.898 μs |  3.0323 μs |   8.9408 μs |   110.068 μs |      - |      - |         - |
| LeopotamEcsLite                        | 100000      | 0             |   124.800 μs |  1.6705 μs |   2.1721 μs |   124.373 μs |      - |      - |         - |
| LeopotamEcsLite                        | 100000      | 10            |   131.417 μs |  1.9160 μs |   1.7922 μs |   131.473 μs |      - |      - |         - |
| Myriad_Enumerable                      | 100000      | 10            |   132.649 μs |  1.8543 μs |   1.7345 μs |   132.287 μs |      - |      - |         - |
| RelEcs                                 | 100000      | 0             |   144.375 μs |  6.7776 μs |  19.9839 μs |   132.786 μs |      - |      - |      72 B |
| Myriad_Enumerable                      | 100000      | 0             |   162.740 μs |  1.0929 μs |   0.9688 μs |   162.557 μs |      - |      - |         - |
| RelEcs                                 | 100000      | 10            |   182.942 μs |  2.2971 μs |   3.7094 μs |   182.550 μs |      - |      - |      73 B |
| Myriad_MultiThread                     | 100000      | 10            |   193.401 μs |  3.8406 μs |   5.5081 μs |   194.599 μs | 2.1973 | 0.2441 |   38195 B |
| Myriad_MultiThread                     | 100000      | 0             |   209.680 μs |  3.9378 μs |   4.3769 μs |   209.912 μs | 2.1973 | 0.2441 |   38719 B |
| MonoGameExtended                       | 100000      | 0             |   368.140 μs |  4.8073 μs |   4.4968 μs |   367.828 μs |      - |      - |     161 B |
| MonoGameExtended                       | 100000      | 10            |   381.710 μs |  4.1886 μs |   3.9180 μs |   381.134 μs |      - |      - |     161 B |
| Morpeh_Stash                           | 100000      | 0             |   680.692 μs | 20.4174 μs |  60.2012 μs |   643.423 μs |      - |      - |       1 B |
| Morpeh_Direct                          | 100000      | 0             | 1,121.348 μs | 29.6766 μs |  87.5020 μs | 1,163.342 μs |      - |      - |         - |
| Morpeh_Stash                           | 100000      | 10            | 1,825.451 μs | 36.1075 μs |  84.4002 μs | 1,789.346 μs |      - |      - |         - |
| Morpeh_Direct                          | 100000      | 10            | 2,290.148 μs | 62.4139 μs | 171.9060 μs | 2,220.245 μs |      - |      - |         - |
