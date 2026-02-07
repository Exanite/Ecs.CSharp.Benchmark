```

BenchmarkDotNet v0.13.12, Arch Linux
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.125.57005), X64 RyuJIT AVX2
  DefaultJob : .NET 10.0.1 (10.0.125.57005), X64 RyuJIT AVX2


```
| Method                          | EntityCount | Mean | Error |
|-------------------------------- |------------ |-----:|------:|
| Arch                            | 100000      |   NA |    NA |
| Arch_MonoThread_SourceGenerated | 100000      |   NA |    NA |
| Arch_MultiThread                | 100000      |   NA |    NA |
| DefaultEcs_MonoThread           | 100000      |   NA |    NA |
| DefaultEcs_MultiThread          | 100000      |   NA |    NA |
| Exanite                         | 100000      |   NA |    NA |
| Fennecs_ForEach                 | 100000      |   NA |    NA |
| Fennecs_Job                     | 100000      |   NA |    NA |
| Fennecs_Raw                     | 100000      |   NA |    NA |
| FlecsNet_Each                   | 100000      |   NA |    NA |
| FlecsNet_Iter                   | 100000      |   NA |    NA |
| Frent_QueryInline               | 100000      |   NA |    NA |
| Frent_Simd                      | 100000      |   NA |    NA |
| FrifloEngineEcs_MonoThread      | 100000      |   NA |    NA |
| FrifloEngineEcs_MultiThread     | 100000      |   NA |    NA |
| FrifloEngineEcs_SIMD_MonoThread | 100000      |   NA |    NA |
| HypEcs_MonoThread               | 100000      |   NA |    NA |
| HypEcs_MultiThread              | 100000      |   NA |    NA |
| LeopotamEcsLite                 | 100000      |   NA |    NA |
| LeopotamEcs                     | 100000      |   NA |    NA |
| MonoGameExtended                | 100000      |   NA |    NA |
| Morpeh_Direct                   | 100000      |   NA |    NA |
| Morpeh_Stash                    | 100000      |   NA |    NA |
| Myriad_SingleThread             | 100000      |   NA |    NA |
| Myriad_MultiThread              | 100000      |   NA |    NA |
| Myriad_SingleThreadChunk        | 100000      |   NA |    NA |
| Myriad_MultiThreadChunk         | 100000      |   NA |    NA |
| Myriad_Enumerable               | 100000      |   NA |    NA |
| Myriad_Delegate                 | 100000      |   NA |    NA |
| Myriad_SingleThreadChunk_SIMD   | 100000      |   NA |    NA |
| RelEcs                          | 100000      |   NA |    NA |
| SveltoECS                       | 100000      |   NA |    NA |
| TinyEcs_Each                    | 100000      |   NA |    NA |
| TinyEcs_EachJob                 | 100000      |   NA |    NA |

Benchmarks with issues:
  SystemWithTwoComponentsMultipleComposition.Arch: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Arch_MonoThread_SourceGenerated: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Arch_MultiThread: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.DefaultEcs_MonoThread: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.DefaultEcs_MultiThread: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Exanite: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Fennecs_ForEach: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Fennecs_Job: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Fennecs_Raw: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.FlecsNet_Each: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.FlecsNet_Iter: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Frent_QueryInline: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Frent_Simd: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.FrifloEngineEcs_MonoThread: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.FrifloEngineEcs_MultiThread: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.FrifloEngineEcs_SIMD_MonoThread: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.HypEcs_MonoThread: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.HypEcs_MultiThread: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.LeopotamEcsLite: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.LeopotamEcs: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.MonoGameExtended: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Morpeh_Direct: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Morpeh_Stash: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Myriad_SingleThread: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Myriad_MultiThread: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Myriad_SingleThreadChunk: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Myriad_MultiThreadChunk: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Myriad_Enumerable: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Myriad_Delegate: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.Myriad_SingleThreadChunk_SIMD: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.RelEcs: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.SveltoECS: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.TinyEcs_Each: DefaultJob [EntityCount=100000]
  SystemWithTwoComponentsMultipleComposition.TinyEcs_EachJob: DefaultJob [EntityCount=100000]
