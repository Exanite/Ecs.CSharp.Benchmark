## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithTwoComponents.Exanite()
       mov       rsi,[rdi+88]
       jmp       qword ptr [7F69AF055CF8]; Ecs.CSharp.Benchmark.SystemWithTwoComponents.UpdateExaniteQuery(Exanite.Myriad.Ecs.IArchetypeView)
; Total bytes of code 13
```
```assembly
; Ecs.CSharp.Benchmark.SystemWithTwoComponents.UpdateExaniteQuery(Exanite.Myriad.Ecs.IArchetypeView)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rdi,rsi
       mov       rax,offset MT_Exanite.Myriad.Ecs.Queries.QueryView
       cmp       [rdi],rax
       jne       near ptr M01_L11
       mov       rax,[rdi+8]
       mov       ecx,[rax+10]
       mov       rdx,[rdi+18]
       cmp       ecx,[rdx+58]
       jne       near ptr M01_L09
M01_L00:
       mov       rax,[rax+8]
       xor       ebx,ebx
       xor       r15d,r15d
       test      rax,rax
       je        short M01_L01
       mov       r15d,[rax+10]
       mov       rbx,[rax+8]
       cmp       [rbx+8],r15d
       jb        near ptr M01_L10
       add       rbx,10
M01_L01:
       xor       eax,eax
       cmp       eax,r15d
       jl        short M01_L04
M01_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M01_L03:
       inc       eax
       cmp       eax,r15d
       jge       short M01_L02
M01_L04:
       mov       rcx,[rbx+rax*8]
       mov       rdx,[rcx+18]
       mov       edi,[rcx+10]
       mov       esi,edi
       test      rdx,rdx
       je        near ptr M01_L12
       cmp       [rdx+8],esi
       jb        near ptr M01_L15
M01_L05:
       test      esi,esi
       je        short M01_L03
       mov       rdx,[rcx+20]
       mov       r8,rdx
       mov       rcx,[rcx+40]
       mov       r9,rcx
       mov       r10d,[r9+8]
       cmp       r10d,1
       jbe       near ptr M01_L16
       mov       r9d,[r9+14]
       mov       r11d,[r8+8]
       cmp       r9d,r11d
       jae       near ptr M01_L16
       mov       r8,[r8+r9*8+10]
       mov       r9d,edi
       test      r8,r8
       je        near ptr M01_L13
       cmp       [r8+8],r9d
       jb        near ptr M01_L15
       add       r8,10
M01_L06:
       cmp       r10d,2
       jbe       near ptr M01_L16
       mov       ecx,[rcx+18]
       cmp       ecx,r11d
       jae       near ptr M01_L16
       mov       rcx,[rdx+rcx*8+10]
       test      rcx,rcx
       je        near ptr M01_L14
       cmp       [rcx+8],edi
       jb        near ptr M01_L15
       add       rcx,10
M01_L07:
       cmp       r9d,esi
       jl        near ptr M01_L03
       cmp       edi,esi
       jl        near ptr M01_L03
       test      esi,esi
       jle       near ptr M01_L03
       xor       edx,edx
M01_L08:
       lea       rdi,[r8+rdx]
       lea       r9,[rcx+rdx]
       mov       r9d,[r9]
       add       [rdi],r9d
       add       rdx,4
       dec       esi
       jne       short M01_L08
       jmp       near ptr M01_L03
M01_L09:
       call      qword ptr [7F69AF055E18]; Exanite.Myriad.Ecs.Queries.QueryView.GetMatchResultCold(Exanite.Myriad.Ecs.Queries.QueryView)
       jmp       near ptr M01_L00
M01_L10:
       call      qword ptr [7F69A963F5E8]
       int       3
M01_L11:
       mov       r11,7F69A8651B48
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r15d,edx
       jmp       near ptr M01_L01
M01_L12:
       test      esi,esi
       jne       short M01_L15
       xor       esi,esi
       jmp       near ptr M01_L05
M01_L13:
       test      r9d,r9d
       jne       short M01_L15
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M01_L06
M01_L14:
       test      edi,edi
       jne       short M01_L15
       xor       ecx,ecx
       xor       edi,edi
       jmp       near ptr M01_L07
M01_L15:
       call      qword ptr [7F69A9A77ED0]
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 415
```

