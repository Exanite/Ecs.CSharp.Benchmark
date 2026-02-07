## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithTwoComponents.Exanite()
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rdi,[rdi+88]
       mov       rax,offset MT_Exanite.Myriad.Ecs.Queries.QueryView
       cmp       [rdi],rax
       jne       near ptr M00_L12
       mov       rax,[rdi+8]
       mov       ecx,[rax+10]
       mov       rdx,[rdi+18]
       cmp       ecx,[rdx+58]
       jne       near ptr M00_L10
M00_L00:
       mov       rax,[rax+8]
       xor       ebx,ebx
       xor       r15d,r15d
       test      rax,rax
       je        short M00_L01
       mov       r15d,[rax+10]
       mov       rbx,[rax+8]
       cmp       [rbx+8],r15d
       jb        near ptr M00_L11
       add       rbx,10
M00_L01:
       xor       eax,eax
       cmp       eax,r15d
       jl        short M00_L05
M00_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M00_L03:
       cmp       edx,r9d
       jae       near ptr M00_L17
       mov       r11d,edx
       shl       r11,2
       lea       r10,[r8+r11]
       cmp       edx,edi
       jae       near ptr M00_L17
       add       r11,rcx
       mov       r11d,[r11]
       add       [r10],r11d
       inc       edx
       cmp       edx,esi
       jl        short M00_L03
M00_L04:
       inc       eax
       cmp       eax,r15d
       jge       short M00_L02
M00_L05:
       mov       rcx,[rbx+rax*8]
       mov       rdx,[rcx+18]
       mov       edi,[rcx+10]
       mov       esi,edi
       test      rdx,rdx
       je        near ptr M00_L13
       cmp       [rdx+8],esi
       jb        near ptr M00_L16
M00_L06:
       test      esi,esi
       je        short M00_L04
       mov       rdx,[rcx+20]
       mov       r8,rdx
       mov       rcx,[rcx+40]
       mov       r9,rcx
       mov       r10d,[r9+8]
       cmp       r10d,1
       jbe       near ptr M00_L17
       mov       r9d,[r9+14]
       mov       r11d,[r8+8]
       cmp       r9d,r11d
       jae       near ptr M00_L17
       mov       r8,[r8+r9*8+10]
       mov       r9d,edi
       test      r8,r8
       je        near ptr M00_L14
       cmp       [r8+8],r9d
       jb        near ptr M00_L16
       add       r8,10
M00_L07:
       cmp       r10d,2
       jbe       near ptr M00_L17
       mov       ecx,[rcx+18]
       cmp       ecx,r11d
       jae       near ptr M00_L17
       mov       rcx,[rdx+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L15
       cmp       [rcx+8],edi
       jb        near ptr M00_L16
       add       rcx,10
M00_L08:
       mov       edx,r9d
       or        edx,edi
       cmp       edx,esi
       jl        near ptr M00_L04
       xor       edx,edx
       test      esi,esi
       jle       near ptr M00_L04
       cmp       esi,r9d
       jg        near ptr M00_L03
       cmp       esi,edi
       jg        near ptr M00_L03
       xor       edx,edx
M00_L09:
       lea       r10,[r8+rdx]
       lea       r11,[rcx+rdx]
       mov       r9d,[r11]
       add       [r10],r9d
       add       rdx,4
       dec       esi
       jne       short M00_L09
       jmp       near ptr M00_L04
M00_L10:
       call      qword ptr [7F8D53855DD0]; Exanite.Myriad.Ecs.Queries.QueryView.GetMatchResultCold(Exanite.Myriad.Ecs.Queries.QueryView)
       jmp       near ptr M00_L00
M00_L11:
       call      qword ptr [7F8D4DE2F5E8]
       int       3
M00_L12:
       mov       r11,7F8D4CE41C20
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r15d,edx
       jmp       near ptr M00_L01
M00_L13:
       test      esi,esi
       jne       short M00_L16
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L14:
       test      r9d,r9d
       jne       short M00_L16
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M00_L07
M00_L15:
       test      edi,edi
       jne       short M00_L16
       xor       ecx,ecx
       xor       edi,edi
       jmp       near ptr M00_L08
M00_L16:
       call      qword ptr [7F8D4E267ED0]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 477
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
       mov       rdi,[rax+10]
       cmp       [rdi],edi
       call      qword ptr [7F8D4EAFFCF0]; System.Threading.Lock.EnterScope()
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
       call      qword ptr [7F8D53855DB8]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       [rbp-58],rax
       mov       rdi,[rbp-58]
       cmp       [rdi],edi
       call      qword ptr [7F8D4EA02570]; Precode of Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       [rbp-0C0],rax
       mov       [rbp-0B8],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-0C0]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       lea       rsi,[rbp-88]
       mov       rdi,offset MT_Exanite.Core.Pooling.SimplePool<Exanite.Myriad.Ecs.Collections.OrderedListSet<Exanite.Myriad.Ecs.Components.ComponentId>>
       call      qword ptr [7F8D53855E30]; Exanite.Core.Pooling.SimplePool`1[[System.__Canon, System.Private.CoreLib]].Acquire(System.__Canon ByRef)
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
       call      qword ptr [7F8D53855E48]; Exanite.Myriad.Ecs.Queries.QueryView.IsMatch(Exanite.Myriad.Ecs.Worlds.Archetype, Exanite.Myriad.Ecs.Collections.OrderedListSet`1<Exanite.Myriad.Ecs.Components.ComponentId>)
       test      eax,eax
       je        short M01_L03
       cmp       qword ptr [rbp-50],0
       jne       short M01_L02
       mov       rdi,7F8D5389A300
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,offset MT_Exanite.Core.Pooling.CollectionPool<System.Collections.Generic.List<Exanite.Myriad.Ecs.Worlds.Archetype>, Exanite.Myriad.Ecs.Worlds.Archetype>
       call      qword ptr [7F8D53855E60]; Exanite.Core.Pooling.CollectionPool`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Acquire()
       mov       [rbp-50],rax
       mov       rax,[rbp-48]
       mov       rsi,[rax+8]
       mov       rdi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [7F8D4EAF7D68]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M01_L02:
       mov       rdi,7F8D5389A304
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-50]
       mov       rsi,[rbp-98]
       cmp       [rdi],edi
       call      qword ptr [7F8D4DF354E0]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L03:
       mov       rdi,7F8D5389A308
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
       call      qword ptr [7F8D4EC243D8]; Exanite.Myriad.Ecs.Queries.QueryView+MatchResult..ctor(Int32, System.Collections.Generic.List`1<Exanite.Myriad.Ecs.Worlds.Archetype>)
       mov       rax,[rbp-0E0]
       mov       [rbp-70],rax
       jmp       short M01_L07
M01_L06:
       mov       rdi,7F8D5389A310
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,offset MT_Exanite.Myriad.Ecs.Queries.QueryView+MatchResult
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdi,[rbp-0D8]
       mov       esi,[rbp-60]
       mov       rdx,[rbp-50]
       call      qword ptr [7F8D4EC243D8]; Exanite.Myriad.Ecs.Queries.QueryView+MatchResult..ctor(Int32, System.Collections.Generic.List`1<Exanite.Myriad.Ecs.Worlds.Archetype>)
       mov       rax,[rbp-0D8]
       mov       [rbp-70],rax
       mov       rax,[rbp-48]
       mov       rsi,[rax+8]
       mov       rdi,[rbp-58]
       cmp       [rdi],edi
       call      qword ptr [7F8D53855E78]; Exanite.Myriad.Ecs.EcsWorld.Recycle(System.Collections.Generic.List`1<Exanite.Myriad.Ecs.Worlds.Archetype>)
M01_L07:
       mov       rax,[rbp-30]
       lea       rdi,[rax+8]
       mov       rsi,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
       mov       [rbp-0A0],rax
       call      M01_L09
       nop
       mov       rdi,7F8D5389A318
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-0A0]
       add       rsp,0F0
       pop       rbp
       ret
M01_L08:
       push      rax
       mov       rdi,7F8D5389A30C
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdi,[rbp-80]
       mov       rsi,offset MT_Exanite.Core.Pooling.Pool<Exanite.Myriad.Ecs.Collections.OrderedListSet<Exanite.Myriad.Ecs.Components.ComponentId>>+Handle
       call      qword ptr [7F8D4EC263E8]; Exanite.Core.Pooling.Pool`1+Handle[[System.__Canon, System.Private.CoreLib]].Dispose()
       nop
       add       rsp,8
       ret
M01_L09:
       push      rax
       mov       rdi,7F8D5389A314
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdi,[rbp-40]
       call      qword ptr [7F8D4EAFFD38]; System.Threading.Lock+Scope.Dispose()
       nop
       add       rsp,8
       ret
; Total bytes of code 805
```

