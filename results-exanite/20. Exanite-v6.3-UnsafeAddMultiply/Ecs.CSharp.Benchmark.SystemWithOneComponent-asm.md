## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithOneComponent.Exanite()
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rdi,[rdi+88]
       mov       rax,offset MT_Exanite.Myriad.Ecs.Queries.QueryView
       cmp       [rdi],rax
       jne       near ptr M00_L10
       mov       rax,[rdi+8]
       mov       ecx,[rax+10]
       mov       rdx,[rdi+10]
       cmp       ecx,[rdx+58]
       jne       near ptr M00_L08
M00_L00:
       mov       rax,[rax+8]
       xor       ebx,ebx
       xor       r15d,r15d
       test      rax,rax
       je        short M00_L01
       mov       r15d,[rax+10]
       mov       rbx,[rax+8]
       cmp       [rbx+8],r15d
       jb        near ptr M00_L09
       add       rbx,10
M00_L01:
       xor       eax,eax
       cmp       eax,r15d
       jl        short M00_L04
M00_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M00_L03:
       inc       eax
       cmp       eax,r15d
       jge       short M00_L02
M00_L04:
       mov       rcx,[rbx+rax*8]
       mov       rdx,[rcx+18]
       mov       edi,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L11
       cmp       [rdx+8],edi
       jb        near ptr M00_L13
M00_L05:
       test      edi,edi
       je        short M00_L03
       mov       rdx,[rcx+20]
       mov       rsi,[rcx+40]
       cmp       dword ptr [rsi+8],1
       jbe       near ptr M00_L14
       mov       esi,[rsi+14]
       cmp       esi,[rdx+8]
       jae       short M00_L14
       mov       rdx,[rdx+rsi*8+10]
       mov       ecx,[rcx+10]
       test      rdx,rdx
       je        short M00_L12
       cmp       [rdx+8],ecx
       jb        short M00_L13
       add       rdx,10
M00_L06:
       xor       ecx,ecx
       test      edi,edi
       jle       short M00_L03
M00_L07:
       movsxd    rsi,ecx
       lea       rsi,[rdx+rsi*4]
       inc       dword ptr [rsi]
       inc       ecx
       cmp       ecx,edi
       jl        short M00_L07
       jmp       short M00_L03
M00_L08:
       call      qword ptr [7F573F916BF8]; Exanite.Myriad.Ecs.Queries.QueryView.GetMatchResultCold(Exanite.Myriad.Ecs.Queries.QueryView)
       jmp       near ptr M00_L00
M00_L09:
       call      qword ptr [7F573A02F5E8]
       int       3
M00_L10:
       mov       r11,7F5739041548
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r15d,edx
       jmp       near ptr M00_L01
M00_L11:
       test      edi,edi
       jne       short M00_L13
       xor       edi,edi
       jmp       short M00_L05
M00_L12:
       test      ecx,ecx
       jne       short M00_L13
       xor       edx,edx
       jmp       short M00_L06
M00_L13:
       call      qword ptr [7F573A467ED0]
       int       3
M00_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 285
```
```assembly
; Exanite.Myriad.Ecs.Queries.QueryView.GetMatchResultCold(Exanite.Myriad.Ecs.Queries.QueryView)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-0E0],ymm8
       vmovdqu   ymmword ptr [rbp-0C0],ymm8
       vmovdqu   ymmword ptr [rbp-0A0],ymm8
       vmovdqu   ymmword ptr [rbp-80],ymm8
       vmovdqu   ymmword ptr [rbp-60],ymm8
       vmovdqa   xmmword ptr [rbp-40],xmm8
       mov       [rbp-30],rdi
       mov       dword ptr [rbp-0E8],3E8
       mov       rax,[rbp-30]
       mov       rdi,[rax+18]
       cmp       [rdi],edi
       call      qword ptr [7F573ACFF150]; System.Threading.Lock.EnterScope()
       mov       [rbp-0B0],rax
       mov       [rbp-0A8],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-0B0]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       mov       rax,[rbp-30]
       mov       rax,[rax+8]
       mov       [rbp-48],rax
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rdi,[rbp-30]
       cmp       [rdi],edi
       call      qword ptr [7F573F916BE0]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       [rbp-58],rax
       mov       rdi,[rbp-58]
       cmp       [rdi],edi
       call      qword ptr [7F573AC01508]; Precode of Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       [rbp-0C0],rax
       mov       [rbp-0B8],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-0C0]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       lea       rsi,[rbp-88]
       mov       rdi,offset MT_Exanite.Core.Pooling.SimplePool<Exanite.Myriad.Ecs.Collections.OrderedListSet<Exanite.Myriad.Ecs.Components.ComponentId>>
       call      qword ptr [7F573F916C58]; Exanite.Core.Pooling.SimplePool`1[[System.__Canon, System.Private.CoreLib]].Acquire(System.__Canon ByRef)
       mov       [rbp-0D0],rax
       mov       [rbp-0C8],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-0D0]
       vmovdqu   xmmword ptr [rbp-80],xmm0
       mov       rax,[rbp-48]
       mov       eax,[rax+10]
       mov       [rbp-8C],eax
       jmp       near ptr M01_L04
M01_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L01:
       mov       eax,[rbp-60]
       cmp       [rbp-8C],eax
       jae       short M01_L00
       mov       eax,[rbp-8C]
       mov       rcx,[rbp-68]
       mov       rax,[rcx+rax*8]
       mov       [rbp-98],rax
       mov       rdi,[rbp-30]
       mov       rsi,[rbp-98]
       mov       rdx,[rbp-88]
       cmp       [rdi],edi
       call      qword ptr [7F573F916C70]; Exanite.Myriad.Ecs.Queries.QueryView.IsMatch(Exanite.Myriad.Ecs.Worlds.Archetype, Exanite.Myriad.Ecs.Collections.OrderedListSet`1<Exanite.Myriad.Ecs.Components.ComponentId>)
       test      eax,eax
       je        short M01_L03
       cmp       qword ptr [rbp-50],0
       jne       short M01_L02
       mov       rdi,7F573F96BF28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,offset MT_Exanite.Core.Pooling.CollectionPool<System.Collections.Generic.List<Exanite.Myriad.Ecs.Worlds.Archetype>, Exanite.Myriad.Ecs.Worlds.Archetype>
       call      qword ptr [7F573F916C88]; Exanite.Core.Pooling.CollectionPool`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Acquire()
       mov       [rbp-50],rax
       mov       rax,[rbp-48]
       mov       rsi,[rax+8]
       mov       rdi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [7F573ACFC1B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M01_L02:
       mov       rdi,7F573F96BF2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-50]
       mov       rsi,[rbp-98]
       cmp       [rdi],edi
       call      qword ptr [7F573A1354E0]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L03:
       mov       rdi,7F573F96BF30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-8C]
       inc       eax
       mov       [rbp-8C],eax
M01_L04:
       mov       eax,[rbp-0E8]
       dec       eax
       mov       [rbp-0E8],eax
       cmp       dword ptr [rbp-0E8],0
       jg        short M01_L05
       lea       rdi,[rbp-0E8]
       mov       esi,77
       call      CORINFO_HELP_PATCHPOINT
M01_L05:
       mov       eax,[rbp-8C]
       cmp       eax,[rbp-60]
       jl        near ptr M01_L01
       call      M01_L08
       nop
       cmp       qword ptr [rbp-50],0
       jne       short M01_L06
       mov       rdi,offset MT_Exanite.Myriad.Ecs.Queries.QueryView+MatchResult
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0E0],rax
       mov       rax,[rbp-48]
       mov       rdx,[rax+8]
       mov       rdi,[rbp-0E0]
       mov       esi,[rbp-60]
       call      qword ptr [7F573ACFF840]; Exanite.Myriad.Ecs.Queries.QueryView+MatchResult..ctor(Int32, System.Collections.Generic.List`1<Exanite.Myriad.Ecs.Worlds.Archetype>)
       mov       rax,[rbp-0E0]
       mov       [rbp-70],rax
       jmp       short M01_L07
M01_L06:
       mov       rdi,7F573F96BF38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,offset MT_Exanite.Myriad.Ecs.Queries.QueryView+MatchResult
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdi,[rbp-0D8]
       mov       esi,[rbp-60]
       mov       rdx,[rbp-50]
       call      qword ptr [7F573ACFF840]; Exanite.Myriad.Ecs.Queries.QueryView+MatchResult..ctor(Int32, System.Collections.Generic.List`1<Exanite.Myriad.Ecs.Worlds.Archetype>)
       mov       rax,[rbp-0D8]
       mov       [rbp-70],rax
       mov       rax,[rbp-48]
       mov       rsi,[rax+8]
       mov       rdi,[rbp-58]
       cmp       [rdi],edi
       call      qword ptr [7F573F916CA0]; Exanite.Myriad.Ecs.EcsWorld.Recycle(System.Collections.Generic.List`1<Exanite.Myriad.Ecs.Worlds.Archetype>)
M01_L07:
       mov       rax,[rbp-30]
       lea       rdi,[rax+8]
       mov       rsi,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
       mov       [rbp-0A0],rax
       call      M01_L09
       nop
       mov       rdi,7F573F96BF40
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-0A0]
       add       rsp,0F0
       pop       rbp
       ret
M01_L08:
       push      rax
       mov       rdi,7F573F96BF34
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdi,[rbp-80]
       mov       rsi,offset MT_Exanite.Core.Pooling.Pool<Exanite.Myriad.Ecs.Collections.OrderedListSet<Exanite.Myriad.Ecs.Components.ComponentId>>+Handle
       call      qword ptr [7F573AE35608]; Exanite.Core.Pooling.Pool`1+Handle[[System.__Canon, System.Private.CoreLib]].Dispose()
       nop
       add       rsp,8
       ret
M01_L09:
       push      rax
       mov       rdi,7F573F96BF3C
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdi,[rbp-40]
       call      qword ptr [7F573ACFF198]; System.Threading.Lock+Scope.Dispose()
       nop
       add       rsp,8
       ret
; Total bytes of code 805
```

