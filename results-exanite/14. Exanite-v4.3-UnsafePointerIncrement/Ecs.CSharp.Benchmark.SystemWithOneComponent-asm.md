## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithOneComponent.Exanite()
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm8,xmm8,xmm8
       vmovdqa   xmmword ptr [rbp-30],xmm8
       mov       [rbp-20],rax
       mov       rdi,[rdi+88]
       mov       rax,offset MT_Exanite.Myriad.Ecs.Queries.QueryView
       cmp       [rdi],rax
       jne       near ptr M00_L12
       cmp       byte ptr [rdi+40],0
       je        near ptr M00_L10
       lea       rax,[rdi+40]
       cmp       byte ptr [rax],0
       je        near ptr M00_L09
       mov       eax,[rax+20]
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+8]
       xor       edx,edx
       test      rcx,rcx
       je        short M00_L00
       mov       edx,[rcx+10]
       mov       rcx,[rcx+8]
       cmp       [rcx+8],edx
       jb        near ptr M00_L11
M00_L00:
       cmp       eax,edx
       jl        near ptr M00_L10
       add       rdi,40
       add       rdi,8
       mov       rbx,[rdi+8]
M00_L01:
       xor       r15d,r15d
       xor       r14d,r14d
       test      rbx,rbx
       je        short M00_L02
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L11
       add       r15,10
M00_L02:
       xor       eax,eax
       cmp       eax,r14d
       jl        short M00_L05
M00_L03:
       add       rsp,28
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L04:
       inc       eax
       cmp       eax,r14d
       jge       short M00_L03
M00_L05:
       mov       rcx,[r15+rax*8]
       mov       rdx,[rcx+18]
       mov       edi,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L13
       cmp       [rdx+8],edi
       jb        near ptr M00_L15
M00_L06:
       test      edi,edi
       je        short M00_L04
       mov       rdx,[rcx+20]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+8],1
       jbe       near ptr M00_L16
       mov       ecx,[rcx+14]
       cmp       ecx,[rdx+8]
       jae       short M00_L16
       nop       dword ptr [rax]
       mov       rcx,[rdx+rcx*8+10]
       test      rcx,rcx
       je        short M00_L14
       lea       rdx,[rcx+10]
       mov       ecx,[rcx+8]
M00_L07:
       test      edi,edi
       jle       short M00_L04
       nop       dword ptr [rax+rax]
M00_L08:
       inc       dword ptr [rdx]
       add       rdx,4
       dec       edi
       jne       short M00_L08
       jmp       short M00_L04
M00_L09:
       call      qword ptr [7F80BE417828]
       int       3
M00_L10:
       lea       rsi,[rbp-38]
       call      qword ptr [7F80BE526C58]; Exanite.Myriad.Ecs.Queries.QueryView.GetArchetypeMatchResultCold()
       mov       rbx,[rbp-30]
       jmp       near ptr M00_L01
M00_L11:
       call      qword ptr [7F80B8C3F5E8]
       int       3
M00_L12:
       mov       r11,7F80B7C51550
       call      qword ptr [r11]
       mov       r15,rax
       mov       r14d,edx
       jmp       near ptr M00_L02
M00_L13:
       test      edi,edi
       jne       short M00_L15
       xor       edi,edi
       jmp       near ptr M00_L06
M00_L14:
       xor       edx,edx
       jmp       short M00_L07
M00_L15:
       call      qword ptr [7F80B9077ED0]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 385
```
```assembly
; Exanite.Myriad.Ecs.Queries.QueryView.GetArchetypeMatchResultCold()
       push      rbp
       sub       rsp,270
       lea       rbp,[rsp+270]
       vxorps    xmm8,xmm8,xmm8
       mov       rax,0FFFFFFFFFFFFFDF0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm8
       vmovdqa   xmmword ptr [rbp+rax-30],xmm8
       vmovdqa   xmmword ptr [rbp+rax-20],xmm8
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp-30],rdi
       mov       [rbp-38],rsi
       mov       dword ptr [rbp-228],3E8
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+40]
       call      qword ptr [7F80BE526BF8]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_HasValue()
       test      eax,eax
       jne       near ptr M01_L05
       mov       rdi,offset MT_System.Collections.Generic.List<Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1B0],rax
       mov       rdi,[rbp-1B0]
       call      qword ptr [7F80BE526CE8]; System.Collections.Generic.List`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]]..ctor()
       mov       rax,[rbp-1B0]
       mov       [rbp-40],rax
       mov       rdi,[rbp-30]
       call      qword ptr [7F80BE526C28]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [7F80B9811488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       [rbp-1C0],rax
       mov       [rbp-1B8],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-1C0]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       xor       eax,eax
       mov       [rbp-54],eax
       jmp       short M01_L03
M01_L01:
       mov       eax,[rbp-48]
       cmp       [rbp-54],eax
       jae       near ptr M01_L13
       mov       eax,[rbp-54]
       mov       rcx,[rbp-50]
       mov       rax,[rcx+rax*8]
       mov       [rbp-60],rax
       lea       rdx,[rbp-68]
       mov       rdi,[rbp-30]
       mov       rsi,[rbp-60]
       call      qword ptr [7F80BE526D18]; Exanite.Myriad.Ecs.Queries.QueryView.TryMatch(Exanite.Myriad.Ecs.Worlds.Archetype, ArchetypeMatch ByRef)
       test      eax,eax
       je        short M01_L02
       mov       rdi,7F80BE57DE50
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-40]
       mov       rsi,[rbp-68]
       cmp       [rdi],edi
       call      qword ptr [7F80BE57CAD0]; Precode of System.Collections.Generic.List`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]].Add(ArchetypeMatch)
M01_L02:
       mov       rdi,7F80BE57DE54
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-54]
       inc       eax
       mov       [rbp-54],eax
M01_L03:
       mov       eax,[rbp-228]
       dec       eax
       mov       [rbp-228],eax
       cmp       dword ptr [rbp-228],0
       jg        short M01_L04
       lea       rdi,[rbp-228]
       mov       esi,44
       call      CORINFO_HELP_PATCHPOINT
M01_L04:
       mov       eax,[rbp-54]
       cmp       eax,[rbp-48]
       jl        near ptr M01_L01
       mov       rdi,7F80BE57DE58
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-30]
       call      qword ptr [7F80BE526C28]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [7F80B9811488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       [rbp-1D0],rax
       mov       [rbp-1C8],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-1D0]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       eax,[rbp-70]
       mov       [rbp-1D4],eax
       mov       rdi,[rbp-40]
       call      qword ptr [7F80BE526D48]; Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]].Create(System.Collections.Generic.List`1<ArchetypeMatch>)
       mov       [rbp-230],rax
       mov       rdx,[rbp-230]
       lea       rdi,[rbp-1F8]
       mov       esi,[rbp-1D4]
       call      qword ptr [7F80BE526D60]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches..ctor(Int32, Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1<ArchetypeMatch>)
       lea       rdi,[rsp]
       lea       rsi,[rbp-1F8]
       mov       rcx,[rsi]
       mov       [rsp],rcx
       add       rsi,8
       add       rdi,8
       mov       rcx,[rsi]
       mov       [rsp+8],rcx
       add       rsi,8
       add       rdi,8
       mov       rcx,[rsi]
       mov       [rsp+10],rcx
       add       rsi,8
       add       rdi,8
       movsq
       lea       rdi,[rbp-220]
       call      qword ptr [7F80BE526D78]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]]..ctor(ArchetypeMatches)
       mov       rax,[rbp-30]
       lea       rdi,[rax+40]
       lea       rsi,[rbp-220]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+40]
       mov       rsi,[rbp-38]
       call      qword ptr [7F80BE526C10]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       mov       rax,[rbp-38]
       add       rsp,270
       pop       rbp
       ret
M01_L05:
       lea       rsi,[rbp-98]
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+40]
       call      qword ptr [7F80BE526C10]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       mov       rdi,[rbp-30]
       call      qword ptr [7F80BE526C28]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       [rbp-238],rax
       mov       rsi,[rbp-238]
       lea       rdi,[rbp-98]
       call      qword ptr [7F80BE526C40]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches.IsStale(Exanite.Myriad.Ecs.EcsWorld)
       test      eax,eax
       je        near ptr M01_L12
       xor       eax,eax
       mov       [rbp-0A0],rax
       lea       rsi,[rbp-98]
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+40]
       call      qword ptr [7F80BE526C10]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       lea       rdi,[rbp-98]
       call      qword ptr [7F80BE526D90]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches.get_ArchetypeWatermark()
       mov       [rbp-0A4],eax
       jmp       near ptr M01_L09
M01_L06:
       mov       rdi,[rbp-30]
       call      qword ptr [7F80BE526C28]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [7F80B9811488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       [rbp-0E0],rax
       mov       [rbp-0D8],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-0E0]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       eax,[rbp-70]
       cmp       [rbp-0A4],eax
       jae       near ptr M01_L13
       mov       rax,[rbp-78]
       mov       ecx,[rbp-0A4]
       mov       rsi,[rax+rcx*8]
       lea       rdx,[rbp-0B0]
       mov       rdi,[rbp-30]
       call      qword ptr [7F80BE526D18]; Exanite.Myriad.Ecs.Queries.QueryView.TryMatch(Exanite.Myriad.Ecs.Worlds.Archetype, ArchetypeMatch ByRef)
       test      eax,eax
       je        near ptr M01_L08
       cmp       qword ptr [rbp-0A0],0
       jne       short M01_L07
       mov       rdi,7F80BE57DE5C
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rsi,[rbp-98]
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+40]
       call      qword ptr [7F80BE526C10]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       mov       rdi,offset MT_Exanite.Myriad.Ecs.Collections.OrderedListSet<Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0E8],rax
       lea       rdi,[rbp-98]
       call      qword ptr [7F80BE526DA8]
       mov       [rbp-240],rax
       mov       rsi,[rbp-240]
       mov       rdi,[rbp-0E8]
       call      qword ptr [7F80BE526DC0]
       mov       rax,[rbp-0E8]
       mov       [rbp-0A0],rax
M01_L07:
       mov       rdi,7F80BE57DE60
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-0A0]
       mov       rsi,[rbp-0B0]
       cmp       [rdi],edi
       call      qword ptr [7F80BE526DD8]; Exanite.Myriad.Ecs.Collections.OrderedListSet`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]].Add(ArchetypeMatch)
M01_L08:
       mov       rdi,7F80BE57DE64
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-0A4]
       inc       eax
       mov       [rbp-0A4],eax
M01_L09:
       mov       eax,[rbp-228]
       dec       eax
       mov       [rbp-228],eax
       cmp       dword ptr [rbp-228],0
       jg        short M01_L10
       lea       rdi,[rbp-228]
       mov       esi,10E
       call      CORINFO_HELP_PATCHPOINT
M01_L10:
       mov       rdi,[rbp-30]
       call      qword ptr [7F80BE526C28]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [7F80B9811488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       [rbp-0D0],rax
       mov       [rbp-0C8],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-0D0]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       mov       eax,[rbp-0A4]
       cmp       eax,[rbp-0B8]
       jl        near ptr M01_L06
       cmp       qword ptr [rbp-0A0],0
       jne       near ptr M01_L11
       mov       rdi,7F80BE57DE68
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-30]
       call      qword ptr [7F80BE526C28]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [7F80B9811488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       [rbp-158],rax
       mov       [rbp-150],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-158]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       mov       eax,[rbp-0B8]
       mov       [rbp-15C],eax
       lea       rsi,[rbp-98]
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+40]
       call      qword ptr [7F80BE526C10]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       lea       rdi,[rbp-98]
       call      qword ptr [7F80BE526DA8]
       mov       [rbp-248],rax
       mov       rdx,[rbp-248]
       lea       rdi,[rbp-180]
       mov       esi,[rbp-15C]
       call      qword ptr [7F80BE526D60]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches..ctor(Int32, Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1<ArchetypeMatch>)
       lea       rdi,[rsp]
       lea       rsi,[rbp-180]
       mov       rcx,[rsi]
       mov       [rsp],rcx
       add       rsi,8
       add       rdi,8
       mov       rcx,[rsi]
       mov       [rsp+8],rcx
       add       rsi,8
       add       rdi,8
       mov       rcx,[rsi]
       mov       [rsp+10],rcx
       add       rsi,8
       add       rdi,8
       movsq
       lea       rdi,[rbp-1A8]
       call      qword ptr [7F80BE526D78]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]]..ctor(ArchetypeMatches)
       mov       rax,[rbp-30]
       lea       rdi,[rax+40]
       lea       rsi,[rbp-1A8]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       jmp       near ptr M01_L12
M01_L11:
       mov       rdi,7F80BE57DE6C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-30]
       call      qword ptr [7F80BE526C28]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [7F80B9811488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       [rbp-0F8],rax
       mov       [rbp-0F0],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-0F8]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       mov       eax,[rbp-0B8]
       mov       [rbp-0FC],eax
       mov       rdi,[rbp-0A0]
       call      qword ptr [7F80BE526DF0]
       mov       [rbp-250],rax
       mov       rdx,[rbp-250]
       lea       rdi,[rbp-120]
       mov       esi,[rbp-0FC]
       call      qword ptr [7F80BE526D60]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches..ctor(Int32, Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1<ArchetypeMatch>)
       lea       rdi,[rsp]
       lea       rsi,[rbp-120]
       mov       rcx,[rsi]
       mov       [rsp],rcx
       add       rsi,8
       add       rdi,8
       mov       rcx,[rsi]
       mov       [rsp+8],rcx
       add       rsi,8
       add       rdi,8
       mov       rcx,[rsi]
       mov       [rsp+10],rcx
       add       rsi,8
       add       rdi,8
       movsq
       lea       rdi,[rbp-148]
       call      qword ptr [7F80BE526D78]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]]..ctor(ArchetypeMatches)
       mov       rax,[rbp-30]
       lea       rdi,[rax+40]
       lea       rsi,[rbp-148]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
M01_L12:
       mov       rdi,7F80BE57DE70
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+40]
       mov       rsi,[rbp-38]
       call      qword ptr [7F80BE526C10]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       mov       rax,[rbp-38]
       add       rsp,270
       pop       rbp
       ret
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1723
```

