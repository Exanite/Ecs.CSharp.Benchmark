## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithOneComponent.Exanite()
       push      rbp
       push      r15
       push      rbx
       sub       rsp,20
       lea       rbp,[rsp+30]
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-30],ymm8
       mov       rdi,[rdi+88]
       mov       rsi,offset MT_Exanite.Myriad.Ecs.Queries.QueryView
       cmp       [rdi],rsi
       jne       near ptr M00_L09
       lea       rsi,[rbp-30]
       call      qword ptr [7F3522F46C58]; Exanite.Myriad.Ecs.Queries.QueryView.GetArchetypeMatchResult()
       mov       rax,[rbp-28]
       xor       ebx,ebx
       xor       r15d,r15d
       test      rax,rax
       je        short M00_L00
       mov       r15d,[rax+10]
       mov       rbx,[rax+8]
       cmp       [rbx+8],r15d
       jb        short M00_L08
       add       rbx,10
M00_L00:
       xor       eax,eax
       cmp       eax,r15d
       jl        short M00_L05
M00_L01:
       add       rsp,20
       pop       rbx
       pop       r15
       pop       rbp
       ret
M00_L02:
       xor       ecx,ecx
M00_L03:
       lea       rsi,[rdx+rcx]
       inc       dword ptr [rsi]
       add       rcx,4
       dec       edi
       jne       short M00_L03
M00_L04:
       inc       eax
       cmp       eax,r15d
       jge       short M00_L01
M00_L05:
       mov       rcx,[rbx+rax*8]
       mov       rdx,[rcx+18]
       mov       edi,[rcx+10]
       test      rdx,rdx
       je        short M00_L10
       cmp       [rdx+8],edi
       jb        short M00_L12
M00_L06:
       test      edi,edi
       je        short M00_L04
       mov       rdx,[rcx+20]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+8],1
       jbe       short M00_L13
       mov       ecx,[rcx+14]
       cmp       ecx,[rdx+8]
       jae       short M00_L13
       mov       rcx,[rdx+rcx*8+10]
       test      rcx,rcx
       je        short M00_L11
       lea       rdx,[rcx+10]
       mov       ecx,[rcx+8]
M00_L07:
       cmp       ecx,edi
       jl        short M00_L04
       test      edi,edi
       jle       short M00_L04
       jmp       short M00_L02
M00_L08:
       call      qword ptr [7F351D65F5E8]
       int       3
M00_L09:
       mov       r11,7F351C671550
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r15d,edx
       jmp       near ptr M00_L00
M00_L10:
       test      edi,edi
       jne       short M00_L12
       xor       edi,edi
       jmp       short M00_L06
M00_L11:
       xor       edx,edx
       xor       ecx,ecx
       jmp       short M00_L07
M00_L12:
       call      qword ptr [7F351DA97ED0]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 262
```
```assembly
; Exanite.Myriad.Ecs.Queries.QueryView.GetArchetypeMatchResult()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,118
       lea       rbp,[rsp+140]
       vxorps    xmm8,xmm8,xmm8
       vmovdqa   xmmword ptr [rbp-130],xmm8
       mov       rax,0FFFFFFFFFFFFFF10
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-30],xmm8
       vmovdqa   xmmword ptr [rbp+rax-20],xmm8
       vmovdqa   xmmword ptr [rbp+rax-10],xmm8
       add       rax,30
       jne       short M01_L00
       mov       [rbp-30],rax
       mov       rbx,rdi
       mov       r15,rsi
       cmp       byte ptr [rbx+40],0
       je        short M01_L03
       lea       rdi,[rbx+40]
       cmp       byte ptr [rdi],0
       je        near ptr M01_L17
       vmovdqu   ymm0,ymmword ptr [rdi+8]
       vmovdqu   ymmword ptr [rbp-48],ymm0
       mov       rdi,[rbx+10]
       mov       esi,[rbp-30]
       mov       rdi,[rdi+8]
       xor       eax,eax
       test      rdi,rdi
       je        short M01_L01
       mov       eax,[rdi+10]
       mov       rdi,[rdi+8]
       cmp       [rdi+8],eax
       jb        near ptr M01_L18
M01_L01:
       cmp       esi,eax
       jl        near ptr M01_L10
       add       rbx,40
       cmp       byte ptr [rbx],0
       je        near ptr M01_L17
       vmovdqu   ymm0,ymmword ptr [rbx+8]
       vmovdqu   ymmword ptr [r15],ymm0
M01_L02:
       mov       rax,r15
       vzeroupper
       add       rsp,118
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rdi,offset MT_System.Collections.Generic.List<Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,r14
       call      qword ptr [7F3522F46D60]; System.Collections.Generic.List`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]]..ctor()
       mov       rsi,[rbx+10]
       mov       rsi,[rsi+8]
       xor       r13d,r13d
       xor       r12d,r12d
       test      rsi,rsi
       je        short M01_L04
       mov       r12d,[rsi+10]
       mov       r13,[rsi+8]
       cmp       [r13+8],r12d
       jb        near ptr M01_L18
       add       r13,10
M01_L04:
       test      r12d,r12d
       jle       short M01_L08
       xor       eax,eax
M01_L05:
       mov       [rbp-138],rax
       mov       rsi,[rax+r13]
       lea       rdx,[rbp-50]
       mov       rdi,rbx
       call      qword ptr [7F3522F46D90]; Exanite.Myriad.Ecs.Queries.QueryView.TryMatch(Exanite.Myriad.Ecs.Worlds.Archetype, ArchetypeMatch ByRef)
       test      eax,eax
       je        short M01_L07
       mov       rsi,[rbp-50]
       inc       dword ptr [r14+14]
       mov       rdi,[r14+8]
       mov       eax,[r14+10]
       mov       ecx,[rdi+8]
       cmp       ecx,eax
       jbe       short M01_L06
       lea       ecx,[rax+1]
       mov       [r14+10],ecx
       mov       eax,eax
       lea       rdi,[rdi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L07
M01_L06:
       mov       rdi,r14
       call      qword ptr [7F3522F470C0]; System.Collections.Generic.List`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]].AddWithResize(ArchetypeMatch)
M01_L07:
       mov       rax,[rbp-138]
       add       rax,8
       dec       r12d
       jne       short M01_L05
M01_L08:
       mov       rax,[rbx+10]
       mov       rax,[rax+8]
       xor       r13d,r13d
       test      rax,rax
       je        short M01_L09
       mov       r13d,[rax+10]
       mov       rax,[rax+8]
       cmp       [rax+8],r13d
       jb        near ptr M01_L18
M01_L09:
       mov       rdi,r14
       call      qword ptr [7F3522F46DC0]; Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]].Create(System.Collections.Generic.List`1<ArchetypeMatch>)
       mov       rdx,rax
       lea       rdi,[rbp-108]
       mov       esi,r13d
       call      qword ptr [7F3522F46DD8]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches..ctor(Int32, Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1<ArchetypeMatch>)
       vmovdqu   ymm0,ymmword ptr [rbp-108]
       vmovdqu   ymmword ptr [rbp-128],ymm0
       lea       rdx,[rbx+40]
       mov       rdi,rdx
       lea       rsi,[rbp-130]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       byte ptr [rdx],1
       lea       rax,[rbx+40]
       cmp       byte ptr [rax],0
       je        near ptr M01_L17
       vmovdqu   ymm0,ymmword ptr [rax+8]
       vmovdqu   ymmword ptr [r15],ymm0
       jmp       near ptr M01_L02
M01_L10:
       lea       rdi,[rbx+40]
       lea       rsi,[rbp-48]
       call      qword ptr [7F3522F46D18]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       mov       rsi,[rbx+10]
       lea       rdi,[rbp-48]
       call      qword ptr [7F3522F46D48]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches.IsStale(Exanite.Myriad.Ecs.EcsWorld)
       test      eax,eax
       je        near ptr M01_L21
       xor       r14d,r14d
       lea       rdi,[rbx+40]
       lea       rsi,[rbp-48]
       call      qword ptr [7F3522F46D18]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       mov       r13d,[rbp-30]
       jmp       near ptr M01_L15
M01_L11:
       mov       rsi,[rbx+10]
       mov       rsi,[rsi+8]
       xor       edx,edx
       xor       edi,edi
       test      rsi,rsi
       je        short M01_L12
       mov       edi,[rsi+10]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],edi
       jb        near ptr M01_L18
       add       rdx,10
M01_L12:
       cmp       r13d,edi
       jae       near ptr M01_L22
       mov       esi,r13d
       mov       rsi,[rdx+rsi*8]
       lea       rdx,[rbp-58]
       mov       rdi,rbx
       call      qword ptr [7F3522F46D90]; Exanite.Myriad.Ecs.Queries.QueryView.TryMatch(Exanite.Myriad.Ecs.Worlds.Archetype, ArchetypeMatch ByRef)
       test      eax,eax
       je        short M01_L14
       test      r14,r14
       jne       short M01_L13
       lea       rdi,[rbx+40]
       cmp       byte ptr [rdi],0
       je        short M01_L17
       vmovdqu   ymm0,ymmword ptr [rdi+8]
       vmovdqu   ymmword ptr [rbp-48],ymm0
       mov       rdi,offset MT_Exanite.Myriad.Ecs.Collections.OrderedListSet<Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,r14
       mov       rsi,[rbp-48]
       call      qword ptr [7F3522F46E38]
M01_L13:
       mov       rdi,r14
       mov       rsi,[rbp-58]
       cmp       [rdi],edi
       call      qword ptr [7F3522F46E50]; Exanite.Myriad.Ecs.Collections.OrderedListSet`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]].Add(ArchetypeMatch)
M01_L14:
       inc       r13d
M01_L15:
       mov       rsi,[rbx+10]
       mov       rsi,[rsi+8]
       xor       edx,edx
       test      rsi,rsi
       je        short M01_L16
       mov       edx,[rsi+10]
       mov       rsi,[rsi+8]
       cmp       [rsi+8],edx
       jb        short M01_L18
M01_L16:
       cmp       r13d,edx
       jl        near ptr M01_L11
       jmp       short M01_L19
M01_L17:
       call      qword ptr [7F3522E27810]
       int       3
M01_L18:
       call      qword ptr [7F351D65F5E8]
       int       3
M01_L19:
       mov       rdi,[rbx+10]
       cmp       [rdi],edi
       call      qword ptr [7F351E231488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       r13d,edx
       test      r14,r14
       jne       short M01_L20
       lea       rdi,[rbx+40]
       lea       rsi,[rbp-48]
       call      qword ptr [7F3522F46D18]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       lea       rdi,[rbp-0C0]
       mov       esi,r13d
       mov       rdx,[rbp-48]
       call      qword ptr [7F3522F46DD8]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches..ctor(Int32, Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1<ArchetypeMatch>)
       vmovdqu   ymm0,ymmword ptr [rbp-0C0]
       vmovdqu   ymmword ptr [rbp-0E0],ymm0
       lea       rdx,[rbx+40]
       mov       rdi,rdx
       lea       rsi,[rbp-0E8]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       byte ptr [rdx],1
       jmp       short M01_L21
M01_L20:
       mov       rdi,r14
       call      qword ptr [7F3522F46E68]
       mov       rdx,rax
       lea       rdi,[rbp-78]
       mov       esi,r13d
       call      qword ptr [7F3522F46DD8]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches..ctor(Int32, Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1<ArchetypeMatch>)
       vmovdqu   ymm0,ymmword ptr [rbp-78]
       vmovdqu   ymmword ptr [rbp-98],ymm0
       lea       rdx,[rbx+40]
       mov       rdi,rdx
       lea       rsi,[rbp-0A0]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       byte ptr [rdx],1
M01_L21:
       lea       rdi,[rbx+40]
       mov       rsi,r15
       call      qword ptr [7F3522F46D18]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       jmp       near ptr M01_L02
M01_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 977
```

