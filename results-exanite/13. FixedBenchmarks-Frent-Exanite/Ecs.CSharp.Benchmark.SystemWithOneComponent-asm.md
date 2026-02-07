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
       jne       near ptr M00_L13
       cmp       byte ptr [rdi+40],0
       je        near ptr M00_L11
       lea       rax,[rdi+40]
       cmp       byte ptr [rax],0
       je        near ptr M00_L10
       mov       eax,[rax+20]
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+8]
       xor       edx,edx
       test      rcx,rcx
       je        short M00_L00
       mov       edx,[rcx+10]
       mov       rcx,[rcx+8]
       cmp       [rcx+8],edx
       jb        near ptr M00_L12
M00_L00:
       cmp       eax,edx
       jl        near ptr M00_L11
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
       jb        near ptr M00_L12
       add       r15,10
M00_L02:
       xor       eax,eax
       cmp       eax,r14d
       jl        short M00_L07
M00_L03:
       add       rsp,28
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L04:
       xor       ecx,ecx
       nop
M00_L05:
       lea       rsi,[rdx+rcx]
       inc       dword ptr [rsi]
       add       rcx,4
       dec       edi
       jne       short M00_L05
M00_L06:
       inc       eax
       cmp       eax,r14d
       jge       short M00_L03
M00_L07:
       mov       rcx,[r15+rax*8]
       mov       rdx,[rcx+18]
       mov       edi,[rcx+10]
       test      rdx,rdx
       je        short M00_L14
       cmp       [rdx+8],edi
       jb        near ptr M00_L16
M00_L08:
       test      edi,edi
       je        short M00_L06
       mov       rdx,[rcx+20]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+8],1
       jbe       short M00_L17
       mov       ecx,[rcx+14]
       cmp       ecx,[rdx+8]
       jae       short M00_L17
       mov       rcx,[rdx+rcx*8+10]
       test      rcx,rcx
       je        short M00_L15
       lea       rdx,[rcx+10]
       mov       ecx,[rcx+8]
M00_L09:
       cmp       ecx,edi
       jl        short M00_L06
       test      edi,edi
       jle       short M00_L06
       jmp       short M00_L04
M00_L10:
       call      qword ptr [7FB81BC27828]
       int       3
M00_L11:
       lea       rsi,[rbp-38]
       call      qword ptr [7FB81BD46C28]; Exanite.Myriad.Ecs.Queries.QueryView.GetArchetypeMatchResultCold()
       mov       rbx,[rbp-30]
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FB81645F5E8]
       int       3
M00_L13:
       mov       r11,7FB815471550
       call      qword ptr [r11]
       mov       r15,rax
       mov       r14d,edx
       jmp       near ptr M00_L02
M00_L14:
       test      edi,edi
       jne       short M00_L16
       xor       edi,edi
       jmp       short M00_L08
M00_L15:
       xor       edx,edx
       xor       ecx,ecx
       jmp       short M00_L09
M00_L16:
       call      qword ptr [7FB816897ED0]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 375
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
       call      qword ptr [7FB81BD46BC8]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_HasValue()
       test      eax,eax
       jne       near ptr M01_L05
       mov       rdi,offset MT_System.Collections.Generic.List<Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1B0],rax
       mov       rdi,[rbp-1B0]
       call      qword ptr [7FB81BD46CB8]; System.Collections.Generic.List`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]]..ctor()
       mov       rax,[rbp-1B0]
       mov       [rbp-40],rax
       mov       rdi,[rbp-30]
       call      qword ptr [7FB81BD46BF8]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [7FB817031488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
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
       call      qword ptr [7FB81BD46CE8]; Exanite.Myriad.Ecs.Queries.QueryView.TryMatch(Exanite.Myriad.Ecs.Worlds.Archetype, ArchetypeMatch ByRef)
       test      eax,eax
       je        short M01_L02
       mov       rdi,7FB81BD9DD88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-40]
       mov       rsi,[rbp-68]
       cmp       [rdi],edi
       call      qword ptr [7FB81BD9CA08]; Precode of System.Collections.Generic.List`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]].Add(ArchetypeMatch)
M01_L02:
       mov       rdi,7FB81BD9DD8C
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
       mov       rdi,7FB81BD9DD90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-30]
       call      qword ptr [7FB81BD46BF8]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [7FB817031488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       [rbp-1D0],rax
       mov       [rbp-1C8],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-1D0]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       eax,[rbp-70]
       mov       [rbp-1D4],eax
       mov       rdi,[rbp-40]
       call      qword ptr [7FB81BD46D18]; Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]].Create(System.Collections.Generic.List`1<ArchetypeMatch>)
       mov       [rbp-230],rax
       mov       rdx,[rbp-230]
       lea       rdi,[rbp-1F8]
       mov       esi,[rbp-1D4]
       call      qword ptr [7FB81BD46D30]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches..ctor(Int32, Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1<ArchetypeMatch>)
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
       call      qword ptr [7FB81BD46D48]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]]..ctor(ArchetypeMatches)
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
       call      qword ptr [7FB81BD46BE0]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
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
       call      qword ptr [7FB81BD46BE0]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       mov       rdi,[rbp-30]
       call      qword ptr [7FB81BD46BF8]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       [rbp-238],rax
       mov       rsi,[rbp-238]
       lea       rdi,[rbp-98]
       call      qword ptr [7FB81BD46C10]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches.IsStale(Exanite.Myriad.Ecs.EcsWorld)
       test      eax,eax
       je        near ptr M01_L12
       xor       eax,eax
       mov       [rbp-0A0],rax
       lea       rsi,[rbp-98]
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+40]
       call      qword ptr [7FB81BD46BE0]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       lea       rdi,[rbp-98]
       call      qword ptr [7FB81BD46D60]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches.get_ArchetypeWatermark()
       mov       [rbp-0A4],eax
       jmp       near ptr M01_L09
M01_L06:
       mov       rdi,[rbp-30]
       call      qword ptr [7FB81BD46BF8]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [7FB817031488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
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
       call      qword ptr [7FB81BD46CE8]; Exanite.Myriad.Ecs.Queries.QueryView.TryMatch(Exanite.Myriad.Ecs.Worlds.Archetype, ArchetypeMatch ByRef)
       test      eax,eax
       je        near ptr M01_L08
       cmp       qword ptr [rbp-0A0],0
       jne       short M01_L07
       mov       rdi,7FB81BD9DD94
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rsi,[rbp-98]
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+40]
       call      qword ptr [7FB81BD46BE0]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       mov       rdi,offset MT_Exanite.Myriad.Ecs.Collections.OrderedListSet<Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0E8],rax
       lea       rdi,[rbp-98]
       call      qword ptr [7FB81BD46D78]
       mov       [rbp-240],rax
       mov       rsi,[rbp-240]
       mov       rdi,[rbp-0E8]
       call      qword ptr [7FB81BD46D90]
       mov       rax,[rbp-0E8]
       mov       [rbp-0A0],rax
M01_L07:
       mov       rdi,7FB81BD9DD98
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-0A0]
       mov       rsi,[rbp-0B0]
       cmp       [rdi],edi
       call      qword ptr [7FB81BD46DA8]; Exanite.Myriad.Ecs.Collections.OrderedListSet`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]].Add(ArchetypeMatch)
M01_L08:
       mov       rdi,7FB81BD9DD9C
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
       call      qword ptr [7FB81BD46BF8]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [7FB817031488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       [rbp-0D0],rax
       mov       [rbp-0C8],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-0D0]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       mov       eax,[rbp-0A4]
       cmp       eax,[rbp-0B8]
       jl        near ptr M01_L06
       cmp       qword ptr [rbp-0A0],0
       jne       near ptr M01_L11
       mov       rdi,7FB81BD9DDA0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-30]
       call      qword ptr [7FB81BD46BF8]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [7FB817031488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
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
       call      qword ptr [7FB81BD46BE0]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       lea       rdi,[rbp-98]
       call      qword ptr [7FB81BD46D78]
       mov       [rbp-248],rax
       mov       rdx,[rbp-248]
       lea       rdi,[rbp-180]
       mov       esi,[rbp-15C]
       call      qword ptr [7FB81BD46D30]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches..ctor(Int32, Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1<ArchetypeMatch>)
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
       call      qword ptr [7FB81BD46D48]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]]..ctor(ArchetypeMatches)
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
       mov       rdi,7FB81BD9DDA4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-30]
       call      qword ptr [7FB81BD46BF8]; Exanite.Myriad.Ecs.Queries.QueryView.get_World()
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [7FB817031488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       [rbp-0F8],rax
       mov       [rbp-0F0],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-0F8]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       mov       eax,[rbp-0B8]
       mov       [rbp-0FC],eax
       mov       rdi,[rbp-0A0]
       call      qword ptr [7FB81BD46DC0]
       mov       [rbp-250],rax
       mov       rdx,[rbp-250]
       lea       rdi,[rbp-120]
       mov       esi,[rbp-0FC]
       call      qword ptr [7FB81BD46D30]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches..ctor(Int32, Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1<ArchetypeMatch>)
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
       call      qword ptr [7FB81BD46D48]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]]..ctor(ArchetypeMatches)
       mov       rax,[rbp-30]
       lea       rdi,[rax+40]
       lea       rsi,[rbp-148]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
M01_L12:
       mov       rdi,7FB81BD9DDA8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+40]
       mov       rsi,[rbp-38]
       call      qword ptr [7FB81BD46BE0]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       mov       rax,[rbp-38]
       add       rsp,270
       pop       rbp
       ret
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1723
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithOneComponent.Frent_QueryInline()
       push      rbp
       mov       rbp,rsp
       mov       rax,[rdi+30]
       mov       rax,[rax+10]
       cmp       [rax],al
       add       rax,10
       mov       rcx,[rax]
       cmp       [rcx],cl
       add       rcx,10
       mov       eax,[rax+8]
       test      eax,eax
       jle       short M00_L03
       xor       edx,edx
M00_L00:
       mov       rdi,[rcx+rdx]
       mov       rsi,[rdi+18]
       cmp       [rsi],sil
       movzx     esi,byte ptr [rsi+11]
       and       esi,7F
       mov       r8,[rdi+8]
       cmp       [r8],r8b
       movsxd    rsi,esi
       mov       rsi,[r8+rsi*8+10]
       mov       rsi,[rsi+8]
       cmp       [rsi],sil
       add       rsi,10
       movsxd    rdi,dword ptr [rdi+20]
       test      rdi,rdi
       jl        short M00_L02
       nop       word ptr [rax+rax]
M00_L01:
       inc       dword ptr [rsi]
       add       rsi,4
       dec       rdi
       jns       short M00_L01
M00_L02:
       add       rdx,8
       dec       eax
       jne       short M00_L00
M00_L03:
       pop       rbp
       ret
; Total bytes of code 117
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithOneComponent.Frent_QueryDelegate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       rdi,[rdi+30]
       mov       rbx,[rdi+10]
       mov       rdi,7FA4B8C03020
       mov       r15,[rdi]
       test      r15,r15
       je        near ptr M00_L09
M00_L00:
       cmp       [rbx],bl
       add       rbx,10
       mov       r14,[rbx]
       cmp       [r14],r14b
       add       r14,10
       mov       esi,[rbx+8]
       test      esi,esi
       jle       short M00_L04
       mov       rbx,[r15+18]
       mov       rdi,offset Ecs.CSharp.Benchmark.SystemWithOneComponent+<>c.<Frent_QueryDelegate>b__33_0(Component1 ByRef)
       cmp       rbx,rdi
       jne       near ptr M00_L10
       xor       edi,edi
M00_L01:
       mov       rax,[r14+rdi]
       mov       rcx,[rax+18]
       cmp       [rcx],cl
       movzx     edx,byte ptr [rcx+11]
       and       edx,7F
       mov       r8,[rax+8]
       cmp       [r8],r8b
       movsxd    rcx,edx
       mov       rdx,[r8+rcx*8+10]
       mov       r15,[rdx+8]
       cmp       [r15],r15b
       add       r15,10
       mov       r13d,[rax+20]
       test      r13d,r13d
       jl        short M00_L03
       nop       word ptr [rax+rax]
M00_L02:
       inc       dword ptr [r15]
       add       r15,4
       dec       r13d
       jns       short M00_L02
M00_L03:
       add       rdi,8
       dec       esi
       jne       short M00_L01
M00_L04:
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       rax,[r14+r12]
       mov       rcx,[rax+18]
       cmp       [rcx],cl
       movzx     edx,byte ptr [rcx+11]
       and       edx,7F
       mov       r8,[rax+8]
       cmp       [r8],r8b
       movsxd    rsi,edx
       mov       rsi,[r8+rsi*8+10]
       mov       rsi,[rsi+8]
       cmp       [rsi],sil
       add       rsi,10
       mov       r13,rsi
       mov       esi,[rax+20]
       mov       eax,esi
       mov       [rbp-2C],eax
       test      eax,eax
       jl        short M00_L08
       mov       rsi,[r15+18]
       mov       rcx,rsi
M00_L06:
       mov       rsi,offset Ecs.CSharp.Benchmark.SystemWithOneComponent+<>c.<Frent_QueryDelegate>b__33_0(Component1 ByRef)
       mov       [rbp-38],rcx
       cmp       rcx,rsi
       jne       short M00_L11
       inc       dword ptr [r13]
M00_L07:
       add       r13,4
       mov       eax,[rbp-2C]
       dec       eax
       mov       [rbp-2C],eax
       mov       rcx,[rbp-38]
       jns       short M00_L06
M00_L08:
       add       r12,8
       dec       ebx
       jne       short M00_L05
       jmp       near ptr M00_L04
M00_L09:
       mov       rdi,offset MT_Frent.Systems.QueryDelegates+Query<Ecs.CSharp.Benchmark.Contexts.FrentBaseContext+Component1>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,7FA4B8C02FF0
       mov       rsi,[rsi]
       mov       rdi,r15
       mov       rdx,offset Ecs.CSharp.Benchmark.SystemWithOneComponent+<>c.<Frent_QueryDelegate>b__33_0(Component1 ByRef)
       call      qword ptr [7FCC0CC36E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,7FA4B8C03020
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L10:
       xor       r12d,r12d
       mov       ebx,esi
       jmp       near ptr M00_L05
M00_L11:
       mov       rsi,r13
       mov       rdi,[r15+8]
       call      qword ptr [r15+18]
       jmp       short M00_L07
; Total bytes of code 410
```
```assembly
; Ecs.CSharp.Benchmark.SystemWithOneComponent+<>c.<Frent_QueryDelegate>b__33_0(Component1 ByRef)
       inc       dword ptr [rsi]
       ret
; Total bytes of code 3
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      r15
       push      rbx
       push      rax
       mov       rbx,rdi
       mov       r15,rdx
       test      rsi,rsi
       je        short M02_L00
       lea       rdi,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],r15
       add       rsp,8
       pop       rbx
       pop       r15
       ret
M02_L00:
       call      qword ptr [7FCC12604150]
       int       3
; Total bytes of code 43
```

