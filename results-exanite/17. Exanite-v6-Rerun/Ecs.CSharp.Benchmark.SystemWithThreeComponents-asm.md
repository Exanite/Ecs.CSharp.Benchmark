## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithThreeComponents.Exanite()
       mov       rsi,[rdi+88]
       jmp       qword ptr [7F01EA8DF660]; Ecs.CSharp.Benchmark.SystemWithThreeComponents.UpdateExaniteQuery(Exanite.Myriad.Ecs.IArchetypeView)
; Total bytes of code 13
```
```assembly
; Ecs.CSharp.Benchmark.SystemWithThreeComponents.UpdateExaniteQuery(Exanite.Myriad.Ecs.IArchetypeView)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       lea       rbp,[rsp+20]
       mov       rdi,rsi
       mov       rax,offset MT_Exanite.Myriad.Ecs.Queries.QueryView
       cmp       [rdi],rax
       jne       near ptr M01_L12
       mov       rax,[rdi+8]
       mov       ecx,[rax+10]
       mov       rdx,[rdi+18]
       cmp       ecx,[rdx+58]
       jne       near ptr M01_L10
M01_L00:
       mov       rax,[rax+8]
       xor       ebx,ebx
       xor       r15d,r15d
       test      rax,rax
       je        short M01_L01
       mov       r15d,[rax+10]
       mov       rbx,[rax+8]
       cmp       [rbx+8],r15d
       jb        near ptr M01_L11
       add       rbx,10
M01_L01:
       xor       eax,eax
       cmp       eax,r15d
       jl        short M01_L04
M01_L02:
       pop       rbx
       pop       r13
       pop       r14
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
       je        near ptr M01_L13
       cmp       [rdx+8],esi
       jb        near ptr M01_L17
M01_L05:
       test      esi,esi
       je        short M01_L03
       mov       rdx,[rcx+20]
       mov       r8,rdx
       mov       rcx,[rcx+40]
       mov       r9,rcx
       mov       r10d,[r9+8]
       cmp       r10d,1
       jbe       near ptr M01_L18
       mov       r9d,[r9+14]
       mov       r11d,[r8+8]
       cmp       r9d,r11d
       jae       near ptr M01_L18
       mov       r8,[r8+r9*8+10]
       mov       r9d,edi
       test      r8,r8
       je        near ptr M01_L14
       cmp       [r8+8],r9d
       jb        near ptr M01_L17
       add       r8,10
M01_L06:
       mov       r14,rdx
       mov       r13,rcx
       cmp       r10d,2
       jbe       near ptr M01_L18
       mov       r13d,[r13+18]
       cmp       r13d,r11d
       jae       near ptr M01_L18
       mov       r14,[r14+r13*8+10]
       mov       r13d,edi
       test      r14,r14
       je        near ptr M01_L15
       cmp       [r14+8],r13d
       jb        near ptr M01_L17
       add       r14,10
M01_L07:
       cmp       r10d,3
       jbe       near ptr M01_L18
       mov       ecx,[rcx+1C]
       cmp       ecx,r11d
       jae       near ptr M01_L18
       mov       rcx,[rdx+rcx*8+10]
       test      rcx,rcx
       je        near ptr M01_L16
       cmp       [rcx+8],edi
       jb        near ptr M01_L17
       add       rcx,10
M01_L08:
       cmp       r9d,esi
       jl        near ptr M01_L03
       cmp       r13d,esi
       jl        near ptr M01_L03
       cmp       edi,esi
       jl        near ptr M01_L03
       test      esi,esi
       jle       near ptr M01_L03
       xor       edx,edx
M01_L09:
       lea       rdi,[r8+rdx]
       lea       r9,[r14+rdx]
       lea       r10,[rcx+rdx]
       mov       r11d,[rdi]
       add       r11d,[r9]
       add       r11d,[r10]
       mov       [rdi],r11d
       add       rdx,4
       dec       esi
       jne       short M01_L09
       jmp       near ptr M01_L03
M01_L10:
       call      qword ptr [7F01EA8DF780]; Exanite.Myriad.Ecs.Queries.QueryView.GetMatchResultCold(Exanite.Myriad.Ecs.Queries.QueryView)
       jmp       near ptr M01_L00
M01_L11:
       call      qword ptr [7F01E4E5F5E8]
       int       3
M01_L12:
       mov       r11,7F01E3E71E90
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r15d,edx
       jmp       near ptr M01_L01
M01_L13:
       test      esi,esi
       jne       short M01_L17
       xor       esi,esi
       jmp       near ptr M01_L05
M01_L14:
       test      r9d,r9d
       jne       short M01_L17
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M01_L06
M01_L15:
       test      r13d,r13d
       jne       short M01_L17
       xor       r14d,r14d
       xor       r13d,r13d
       jmp       near ptr M01_L07
M01_L16:
       test      edi,edi
       jne       short M01_L17
       xor       ecx,ecx
       xor       edi,edi
       jmp       near ptr M01_L08
M01_L17:
       call      qword ptr [7F01E5297ED0]
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 518
```

