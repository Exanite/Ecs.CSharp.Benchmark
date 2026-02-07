## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithOneComponent.Exanite()
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rdi,[rdi+88]
       mov       rsi,offset MT_Exanite.Myriad.Ecs.Queries.QueryView
       cmp       [rdi],rsi
       jne       near ptr M00_L11
       mov       rsi,[rdi+8]
       mov       eax,[rsi+20]
       mov       rcx,[rdi+18]
       cmp       eax,[rcx+60]
       jne       near ptr M00_L09
M00_L00:
       mov       rax,[rsi+8]
       xor       ebx,ebx
       xor       r15d,r15d
       test      rax,rax
       je        short M00_L01
       mov       r15d,[rax+10]
       mov       rbx,[rax+8]
       cmp       [rbx+8],r15d
       jb        near ptr M00_L10
       add       rbx,10
M00_L01:
       xor       eax,eax
       cmp       eax,r15d
       jl        short M00_L06
M00_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M00_L03:
       xor       ecx,ecx
M00_L04:
       lea       rsi,[rdx+rcx]
       inc       dword ptr [rsi]
       add       rcx,4
       dec       edi
       jne       short M00_L04
M00_L05:
       inc       eax
       cmp       eax,r15d
       jge       short M00_L02
M00_L06:
       mov       rcx,[rbx+rax*8]
       mov       rdx,[rcx+18]
       mov       edi,[rcx+10]
       test      rdx,rdx
       je        short M00_L12
       cmp       [rdx+8],edi
       jb        short M00_L14
M00_L07:
       test      edi,edi
       je        short M00_L05
       mov       rdx,[rcx+20]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+8],1
       jbe       short M00_L15
       mov       ecx,[rcx+14]
       cmp       ecx,[rdx+8]
       jae       short M00_L15
       mov       rcx,[rdx+rcx*8+10]
       test      rcx,rcx
       je        short M00_L13
       lea       rdx,[rcx+10]
       mov       ecx,[rcx+8]
M00_L08:
       cmp       ecx,edi
       jl        short M00_L05
       test      edi,edi
       jle       short M00_L05
       jmp       short M00_L03
M00_L09:
       call      qword ptr [7F72F1B46FE8]; Exanite.Myriad.Ecs.Queries.QueryView.GetMatchResultCold(Exanite.Myriad.Ecs.Queries.QueryView, MatchResult)
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L10:
       call      qword ptr [7F72EC24F5E8]
       int       3
M00_L11:
       mov       r11,7F72EB261590
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r15d,edx
       jmp       near ptr M00_L01
M00_L12:
       test      edi,edi
       jne       short M00_L14
       xor       edi,edi
       jmp       short M00_L07
M00_L13:
       xor       edx,edx
       xor       ecx,ecx
       jmp       short M00_L08
M00_L14:
       call      qword ptr [7F72EC687ED0]
       int       3
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 272
```
```assembly
; Exanite.Myriad.Ecs.Queries.QueryView.GetMatchResultCold(Exanite.Myriad.Ecs.Queries.QueryView, MatchResult)
       push      rbp
       sub       rsp,110
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-108],rax
       vxorps    xmm8,xmm8,xmm8
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm8
       vmovdqa   xmmword ptr [rbp+rax-30],xmm8
       vmovdqa   xmmword ptr [rbp+rax-20],xmm8
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp-30],rdi
       mov       [rbp-38],rsi
       mov       dword ptr [rbp-0F0],3E8
       mov       rax,[rbp-30]
       mov       rdi,[rax+10]
       cmp       [rdi],edi
       call      qword ptr [7F72ECF1F150]; System.Threading.Lock.EnterScope()
       mov       [rbp-0A8],rax
       mov       [rbp-0A0],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-0A8]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rdi,[rbp-30]
       cmp       [rdi],edi
       call      qword ptr [7F72F1B46FD0]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [7F72ECE21538]; Precode of Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-0B8]
       vmovdqu   xmmword ptr [rbp-60],xmm0
       lea       rsi,[rbp-80]
       mov       rdi,offset MT_Exanite.Core.Pooling.SimplePool<Exanite.Myriad.Ecs.Collections.OrderedListSet<Exanite.Myriad.Ecs.Components.ComponentId>>
       call      qword ptr [7F72F1B47048]; Exanite.Core.Pooling.SimplePool`1[[System.__Canon, System.Private.CoreLib]].Acquire(System.__Canon ByRef)
       mov       [rbp-0C8],rax
       mov       [rbp-0C0],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-0C8]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       rax,[rbp-38]
       mov       eax,[rax+20]
       mov       [rbp-84],eax
       jmp       near ptr M01_L05
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L02:
       mov       eax,[rbp-58]
       cmp       [rbp-84],eax
       jae       short M01_L01
       mov       rax,[rbp-60]
       mov       ecx,[rbp-84]
       mov       rsi,[rax+rcx*8]
       lea       rcx,[rbp-90]
       mov       rdi,[rbp-30]
       mov       rdx,[rbp-80]
       cmp       [rdi],edi
       call      qword ptr [7F72F1B47060]; Exanite.Myriad.Ecs.Queries.QueryView.TryMatch(Exanite.Myriad.Ecs.Worlds.Archetype, Exanite.Myriad.Ecs.Collections.OrderedListSet`1<Exanite.Myriad.Ecs.Components.ComponentId>, ArchetypeMatch ByRef)
       test      eax,eax
       je        short M01_L04
       cmp       qword ptr [rbp-50],0
       jne       short M01_L03
       mov       rdi,7F72F1B93A38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,offset MT_Exanite.Myriad.Ecs.Collections.OrderedListSet<Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       rax,[rbp-38]
       mov       rsi,[rax+18]
       mov       rdi,[rbp-0D0]
       call      qword ptr [7F72F1B47078]; Exanite.Myriad.Ecs.Collections.OrderedListSet`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]]..ctor(Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1<ArchetypeMatch>)
       mov       rax,[rbp-0D0]
       mov       [rbp-50],rax
M01_L03:
       mov       rdi,7F72F1B93A3C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-50]
       mov       rsi,[rbp-90]
       cmp       [rdi],edi
       call      qword ptr [7F72F1B47090]; Exanite.Myriad.Ecs.Collections.OrderedListSet`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]].Add(ArchetypeMatch)
M01_L04:
       mov       rdi,7F72F1B93A40
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-84]
       inc       eax
       mov       [rbp-84],eax
M01_L05:
       mov       eax,[rbp-0F0]
       dec       eax
       mov       [rbp-0F0],eax
       cmp       dword ptr [rbp-0F0],0
       jg        short M01_L06
       lea       rdi,[rbp-0F0]
       mov       esi,61
       call      CORINFO_HELP_PATCHPOINT
M01_L06:
       mov       eax,[rbp-84]
       cmp       eax,[rbp-58]
       jl        near ptr M01_L02
       call      M01_L09
       nop
       cmp       qword ptr [rbp-50],0
       jne       short M01_L07
       mov       rdi,offset MT_Exanite.Myriad.Ecs.Queries.QueryView+MatchResult
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0E8],rax
       mov       rax,[rbp-38]
       mov       rdx,[rax+18]
       mov       rdi,[rbp-0E8]
       mov       esi,[rbp-58]
       call      qword ptr [7F72ECF1F8B8]; Exanite.Myriad.Ecs.Queries.QueryView+MatchResult..ctor(Int32, Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1<ArchetypeMatch>)
       mov       rax,[rbp-0E8]
       mov       [rbp-68],rax
       jmp       short M01_L08
M01_L07:
       mov       rdi,7F72F1B93A48
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-58]
       mov       [rbp-0D4],eax
       mov       rdi,offset MT_Exanite.Myriad.Ecs.Queries.QueryView+MatchResult
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0E0],rax
       mov       rdi,[rbp-50]
       call      qword ptr [7F72F1B470A8]; Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]].Create(Exanite.Myriad.Ecs.Collections.OrderedListSet`1<ArchetypeMatch>)
       mov       [rbp-0F8],rax
       mov       rdx,[rbp-0F8]
       mov       esi,[rbp-0D4]
       mov       rdi,[rbp-0E0]
       call      qword ptr [7F72ECF1F8B8]; Exanite.Myriad.Ecs.Queries.QueryView+MatchResult..ctor(Int32, Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1<ArchetypeMatch>)
       mov       rax,[rbp-0E0]
       mov       [rbp-68],rax
M01_L08:
       mov       rax,[rbp-30]
       lea       rdi,[rax+8]
       mov       rsi,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbp-30]
       cmp       [rdi],edi
       call      qword ptr [7F72F1B46FD0]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       [rbp-100],rax
       mov       rdi,[rbp-100]
       mov       rax,[rbp-38]
       mov       rsi,[rax+8]
       cmp       [rdi],edi
       call      qword ptr [7F72F1B470C0]; Exanite.Myriad.Ecs.EcsWorld.Recycle(System.Collections.Generic.List`1<Exanite.Myriad.Ecs.Worlds.Archetype>)
       mov       rdi,[rbp-30]
       cmp       [rdi],edi
       call      qword ptr [7F72F1B46FD0]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       [rbp-108],rax
       mov       rdi,[rbp-108]
       mov       rax,[rbp-38]
       mov       rsi,[rax+10]
       cmp       [rdi],edi
       call      qword ptr [7F72F1B470D8]; Exanite.Myriad.Ecs.EcsWorld.Recycle(System.Collections.Generic.HashSet`1<Exanite.Myriad.Ecs.Worlds.Archetype>)
       mov       rax,[rbp-68]
       mov       [rbp-98],rax
       call      M01_L10
       nop
       mov       rdi,7F72F1B93A50
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-98]
       add       rsp,110
       pop       rbp
       ret
M01_L09:
       push      rax
       mov       rdi,7F72F1B93A44
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdi,[rbp-78]
       mov       rsi,offset MT_Exanite.Core.Pooling.Pool<Exanite.Myriad.Ecs.Collections.OrderedListSet<Exanite.Myriad.Ecs.Components.ComponentId>>+Handle
       call      qword ptr [7F72ED055A28]; Exanite.Core.Pooling.Pool`1+Handle[[System.__Canon, System.Private.CoreLib]].Dispose()
       nop
       add       rsp,8
       ret
M01_L10:
       push      rax
       mov       rdi,7F72F1B93A4C
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdi,[rbp-48]
       call      qword ptr [7F72ECF1F198]; System.Threading.Lock+Scope.Dispose()
       nop
       add       rsp,8
       ret
; Total bytes of code 897
```

