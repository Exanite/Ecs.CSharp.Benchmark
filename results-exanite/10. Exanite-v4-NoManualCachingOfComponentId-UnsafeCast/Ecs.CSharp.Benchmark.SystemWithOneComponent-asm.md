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
       call      qword ptr [7FF4D4526C70]; Exanite.Myriad.Ecs.Queries.QueryView.GetArchetypeMatchResult()
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
       call      qword ptr [7FF4CEC3F5E8]
       int       3
M00_L09:
       mov       r11,7FF4CDC51550
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
       call      qword ptr [7FF4CF077ED0]
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
       push      rbx
       sub       rsp,160
       lea       rbp,[rsp+180]
       xor       eax,eax
       mov       [rbp-15C],rax
       mov       [rbp-154],eax
       vxorps    xmm8,xmm8,xmm8
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-30],xmm8
       vmovdqa   xmmword ptr [rbp+rax-20],xmm8
       vmovdqa   xmmword ptr [rbp+rax-10],xmm8
       add       rax,30
       jne       short M01_L00
       mov       [rbp-30],rax
       mov       [rbp-168],rdi
       mov       [rbp-28],rsi
       mov       rbx,[rdi+8]
       mov       rax,[rbx+8]
       cmp       [rax],al
       mov       esi,0FFFFFFFF
       mov       rdi,rax
       call      qword ptr [7FF4CF07E550]; System.Threading.ReaderWriterLockSlim.TryEnterReadLockCore(TimeoutTracker)
       lea       rax,[rbx+10]
       mov       rdi,[rbx+8]
       mov       [rbp-170],rdi
       cmp       byte ptr [rax],0
       je        near ptr M01_L05
       add       rax,8
       mov       rcx,rax
       mov       ebx,[rcx+18]
       mov       [rbp-15C],ebx
       vmovdqu   ymm0,ymmword ptr [rcx]
       vmovdqu   ymmword ptr [rbp-48],ymm0
       mov       rdi,[rbp-168]
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+8]
       xor       r15d,r15d
       test      rcx,rcx
       je        short M01_L01
       mov       r15d,[rcx+10]
       mov       rcx,[rcx+8]
       cmp       [rcx+8],r15d
       jb        short M01_L02
M01_L01:
       cmp       [rbp-15C],r15d
       jl        short M01_L05
       mov       [rbp-15C],ebx
       vmovdqu   ymm0,ymmword ptr [rax]
       vmovdqu   ymmword ptr [rbp-48],ymm0
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF4CEC3F5E8]
       int       3
M01_L03:
       call      M01_L23
       nop
M01_L04:
       mov       rdx,[rbp-28]
       vmovdqu   ymm0,ymmword ptr [rbp-48]
       vmovdqu   ymmword ptr [rdx],ymm0
       mov       eax,[rbp-15C]
       mov       [rdx+18],eax
       mov       rax,rdx
       vzeroupper
       add       rsp,160
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       call      M01_L23
       nop
       mov       rdi,[rbp-168]
       mov       rdi,[rdi+8]
       lea       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [7FF4D4526D90]; Exanite.Core.Threading.RwLock`1[[System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]], System.Private.CoreLib]].EnterWriteLock(Exanite.Core.Runtime.Ref`1<System.Nullable`1<ArchetypeMatches>> ByRef)
       mov       [rbp-178],rax
       mov       rdi,[rbp-50]
       cmp       byte ptr [rdi],0
       jne       near ptr M01_L10
       mov       rdi,offset MT_System.Collections.Generic.List<Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,rbx
       call      qword ptr [7FF4D4526DA8]; System.Collections.Generic.List`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]]..ctor()
       mov       rdi,[rbp-168]
       mov       rdi,[rdi+18]
       cmp       [rdi],edi
       call      qword ptr [7FF4CF811488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       r15,rax
       mov       r14d,edx
       test      r14d,r14d
       jle       short M01_L09
       xor       r13d,r13d
M01_L06:
       mov       rsi,[r15+r13]
       lea       rdx,[rbp-58]
       mov       rdi,[rbp-168]
       call      qword ptr [7FF4D4526DD8]; Exanite.Myriad.Ecs.Queries.QueryView.TryMatch(Exanite.Myriad.Ecs.Worlds.Archetype, ArchetypeMatch ByRef)
       test      eax,eax
       je        short M01_L08
       mov       rsi,[rbp-58]
       inc       dword ptr [rbx+14]
       mov       rdi,[rbx+8]
       mov       eax,[rbx+10]
       mov       ecx,[rdi+8]
       cmp       ecx,eax
       jbe       short M01_L07
       lea       ecx,[rax+1]
       mov       [rbx+10],ecx
       mov       eax,eax
       lea       rdi,[rdi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L08
M01_L07:
       mov       rdi,rbx
       call      qword ptr [7FF4D4527198]; System.Collections.Generic.List`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]].AddWithResize(ArchetypeMatch)
M01_L08:
       add       r13,8
       dec       r14d
       jne       short M01_L06
M01_L09:
       mov       r15,[rbp-50]
       mov       rdi,[rbp-168]
       mov       rdi,[rdi+18]
       cmp       [rdi],edi
       call      qword ptr [7FF4CF811488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       r14d,edx
       mov       rdi,rbx
       call      qword ptr [7FF4D4526E08]; Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]].Create(System.Collections.Generic.List`1<ArchetypeMatch>)
       mov       rdx,rax
       lea       rdi,[rbp-130]
       mov       esi,r14d
       call      qword ptr [7FF4D4526E20]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches..ctor(Int32, Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1<ArchetypeMatch>)
       vmovdqu   ymm0,ymmword ptr [rbp-130]
       vmovdqu   ymmword ptr [rbp-150],ymm0
       mov       rdi,r15
       lea       rsi,[rbp-158]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       byte ptr [r15],1
       mov       rsi,[rbp-50]
       cmp       byte ptr [rsi],0
       je        near ptr M01_L17
       add       rsi,8
       mov       edi,[rsi+18]
       mov       [rbp-15C],edi
       vmovdqu   ymm0,ymmword ptr [rsi]
       vmovdqu   ymmword ptr [rbp-48],ymm0
       jmp       near ptr M01_L22
M01_L10:
       lea       rsi,[rbp-78]
       mov       rdi,[rbp-50]
       call      qword ptr [7FF4D4526D48]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       mov       rdi,[rbp-168]
       mov       rsi,[rdi+18]
       lea       rdi,[rbp-78]
       call      qword ptr [7FF4D4526D78]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches.IsStale(Exanite.Myriad.Ecs.EcsWorld)
       test      eax,eax
       je        near ptr M01_L21
       xor       ebx,ebx
       lea       rsi,[rbp-78]
       mov       rdi,[rbp-50]
       call      qword ptr [7FF4D4526D48]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       mov       r15d,[rbp-60]
       jmp       near ptr M01_L15
M01_L11:
       mov       rdi,[rbp-168]
       mov       rsi,[rdi+18]
       mov       rsi,[rsi+8]
       xor       edx,edx
       xor       eax,eax
       test      rsi,rsi
       je        short M01_L12
       mov       eax,[rsi+10]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],eax
       jb        near ptr M01_L16
       add       rdx,10
M01_L12:
       cmp       r15d,eax
       jae       near ptr M01_L19
       mov       esi,r15d
       mov       rsi,[rdx+rsi*8]
       lea       rdx,[rbp-80]
       call      qword ptr [7FF4D4526DD8]; Exanite.Myriad.Ecs.Queries.QueryView.TryMatch(Exanite.Myriad.Ecs.Worlds.Archetype, ArchetypeMatch ByRef)
       test      eax,eax
       je        short M01_L14
       test      rbx,rbx
       jne       short M01_L13
       mov       rdi,[rbp-50]
       cmp       byte ptr [rdi],0
       je        short M01_L17
       vmovdqu   ymm0,ymmword ptr [rdi+8]
       vmovdqu   ymmword ptr [rbp-78],ymm0
       mov       rdi,offset MT_Exanite.Myriad.Ecs.Collections.OrderedListSet<Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,rbx
       mov       rsi,[rbp-78]
       call      qword ptr [7FF4D4526E80]
M01_L13:
       mov       rdi,rbx
       mov       rsi,[rbp-80]
       cmp       [rdi],edi
       call      qword ptr [7FF4D4526E98]; Exanite.Myriad.Ecs.Collections.OrderedListSet`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatch, Exanite.Myriad.Ecs]].Add(ArchetypeMatch)
M01_L14:
       inc       r15d
M01_L15:
       mov       rdi,[rbp-168]
       mov       rdi,[rdi+18]
       cmp       [rdi],edi
       call      qword ptr [7FF4CF811488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       r14d,edx
       cmp       r15d,r14d
       jl        near ptr M01_L11
       jmp       short M01_L18
M01_L16:
       call      qword ptr [7FF4CEC3F5E8]
       int       3
M01_L17:
       call      qword ptr [7FF4D4407828]
       int       3
M01_L18:
       test      rbx,rbx
       jne       short M01_L20
       mov       rbx,[rbp-50]
       mov       rdi,[rbp-168]
       mov       rdi,[rdi+18]
       cmp       [rdi],edi
       call      qword ptr [7FF4CF811488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       r14d,edx
       lea       rsi,[rbp-78]
       mov       rdi,[rbp-50]
       call      qword ptr [7FF4D4526D48]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       lea       rdi,[rbp-0E8]
       mov       esi,r14d
       mov       rdx,[rbp-78]
       call      qword ptr [7FF4D4526E20]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches..ctor(Int32, Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1<ArchetypeMatch>)
       vmovdqu   ymm0,ymmword ptr [rbp-0E8]
       vmovdqu   ymmword ptr [rbp-108],ymm0
       mov       rdi,rbx
       lea       rsi,[rbp-110]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       byte ptr [rbx],1
       jmp       short M01_L21
M01_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L20:
       mov       r15,[rbp-50]
       mov       rdi,[rbp-168]
       mov       rdi,[rdi+18]
       cmp       [rdi],edi
       call      qword ptr [7FF4CF811488]; Exanite.Myriad.Ecs.EcsWorld.get_Archetypes()
       mov       r14d,edx
       mov       rdi,rbx
       call      qword ptr [7FF4D4526EB0]
       mov       rdx,rax
       lea       rdi,[rbp-0A0]
       mov       esi,r14d
       call      qword ptr [7FF4D4526E20]; Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches..ctor(Int32, Exanite.Myriad.Ecs.Collections.ImmutableOrderedListSet`1<ArchetypeMatch>)
       vmovdqu   ymm0,ymmword ptr [rbp-0A0]
       vmovdqu   ymmword ptr [rbp-0C0],ymm0
       mov       rdi,r15
       lea       rsi,[rbp-0C8]
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       byte ptr [r15],1
M01_L21:
       lea       rsi,[rbp-48]
       mov       rdi,[rbp-50]
       call      qword ptr [7FF4D4526D48]; System.Nullable`1[[Exanite.Myriad.Ecs.Queries.QueryView+ArchetypeMatches, Exanite.Myriad.Ecs]].get_Value()
       mov       edi,[rbp-30]
       mov       [rbp-15C],edi
M01_L22:
       mov       rdi,[rbp-178]
       cmp       [rdi],edi
       call      qword ptr [7FF4CF07F390]; System.Threading.ReaderWriterLockSlim.ExitWriteLock()
       jmp       near ptr M01_L04
M01_L23:
       push      rax
       mov       rdi,[rbp-170]
       mov       rbx,rdi
       cmp       [rdi],dil
       add       rdi,50
       mov       esi,1
       xchg      sil,[rdi]
       movzx     esi,sil
       test      esi,esi
       je        short M01_L24
       mov       esi,1
       call      qword ptr [7FF4D45F48B8]
M01_L24:
       mov       rdi,7FF54D29D3D8
       mov       rax,7FF54DBAF5B0
       call      rax
       cmp       dword ptr [rax],4
       jle       short M01_L25
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       jne       short M01_L26
M01_L25:
       mov       edi,4
       call      qword ptr [7FF4CF7DFCF0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M01_L26:
       mov       r15,[rax+10]
       test      r15,r15
       je        short M01_L29
       mov       rax,[rbx+28]
M01_L27:
       cmp       [r15+10],rax
       je        short M01_L28
       mov       r15,[r15+8]
       test      r15,r15
       jne       short M01_L27
       jmp       short M01_L29
M01_L28:
       jmp       short M01_L30
M01_L29:
       xor       r15d,r15d
M01_L30:
       test      r15,r15
       je        short M01_L31
       mov       r14d,[r15+18]
       test      r14d,r14d
       jg        short M01_L32
M01_L31:
       lea       rdi,[rbx+50]
       call      qword ptr [7FF4D45F48D0]
       mov       rdi,offset MT_System.Threading.SynchronizationLockException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF4D45F4990]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [7FF4D45F49A8]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L32:
       cmp       byte ptr [rbx+4C],0
       je        short M01_L34
       cmp       r14d,1
       jle       short M01_L33
       dec       r14d
       mov       [r15+18],r14d
       jmp       short M01_L35
M01_L33:
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       eax,[rbx+40]
       jne       short M01_L34
       mov       byte ptr [rbx+4E],0
M01_L34:
       dec       dword ptr [rbx+48]
       dec       dword ptr [r15+18]
       test      byte ptr [rbx+4D],1
       je        short M01_L36
M01_L35:
       mov       byte ptr [rbx+50],0
       jmp       short M01_L37
M01_L36:
       mov       rdi,rbx
       call      qword ptr [7FF4D45F49C0]
M01_L37:
       nop
       vzeroupper
       add       rsp,8
       ret
       push      rax
       mov       rdi,[rbp-178]
       cmp       [rdi],edi
       call      qword ptr [7FF4CF07F390]; System.Threading.ReaderWriterLockSlim.ExitWriteLock()
       nop
       vzeroupper
       add       rsp,8
       ret
; Total bytes of code 1447
```

