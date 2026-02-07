## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithTwoComponentsMultipleComposition.Exanite()
       mov       rsi,[rdi+88]
       jmp       qword ptr [7F41C8035A28]; Ecs.CSharp.Benchmark.SystemWithTwoComponentsMultipleComposition.UpdateExaniteQuery(Exanite.Myriad.Ecs.IArchetypeView)
; Total bytes of code 13
```
```assembly
; Ecs.CSharp.Benchmark.SystemWithTwoComponentsMultipleComposition.UpdateExaniteQuery(Exanite.Myriad.Ecs.IArchetypeView)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rdi,rsi
       mov       rsi,offset MT_Exanite.Myriad.Ecs.Queries.QueryView
       cmp       [rdi],rsi
       jne       near ptr M01_L11
       mov       rsi,[rdi+8]
       mov       eax,[rsi+20]
       mov       rcx,[rdi+18]
       cmp       eax,[rcx+60]
       jne       near ptr M01_L09
M01_L00:
       mov       rax,[rsi+8]
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
       test      rdx,rdx
       je        near ptr M01_L12
       cmp       [rdx+8],edi
       jb        near ptr M01_L15
M01_L05:
       test      edi,edi
       je        short M01_L03
       mov       rdx,[rcx+20]
       mov       rsi,rdx
       mov       rcx,[rcx+40]
       mov       r8,rcx
       mov       r9d,[r8+8]
       cmp       r9d,1
       jbe       near ptr M01_L16
       mov       r8d,[r8+14]
       mov       r10d,[rsi+8]
       cmp       r8d,r10d
       jae       near ptr M01_L16
       mov       rsi,[rsi+r8*8+10]
       test      rsi,rsi
       je        near ptr M01_L13
       lea       r8,[rsi+10]
       mov       esi,[rsi+8]
M01_L06:
       cmp       r9d,2
       jbe       near ptr M01_L16
       mov       ecx,[rcx+18]
       cmp       ecx,r10d
       jae       near ptr M01_L16
       mov       rcx,[rdx+rcx*8+10]
       test      rcx,rcx
       je        near ptr M01_L14
       lea       rdx,[rcx+10]
       mov       ecx,[rcx+8]
M01_L07:
       cmp       esi,edi
       jl        near ptr M01_L03
       cmp       ecx,edi
       jl        near ptr M01_L03
       test      edi,edi
       jle       near ptr M01_L03
       xor       ecx,ecx
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M01_L08:
       lea       rsi,[r8+rcx]
       lea       r9,[rdx+rcx]
       mov       r9d,[r9]
       add       [rsi],r9d
       add       rcx,4
       dec       edi
       jne       short M01_L08
       jmp       near ptr M01_L03
M01_L09:
       call      qword ptr [7F41C8035B48]; Exanite.Myriad.Ecs.Queries.QueryView.GetMatchResultCold(Exanite.Myriad.Ecs.Queries.QueryView, MatchResult)
       mov       rsi,rax
       jmp       near ptr M01_L00
M01_L10:
       call      qword ptr [7F41C243F5E8]
       int       3
M01_L11:
       mov       r11,7F41C1452210
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r15d,edx
       jmp       near ptr M01_L01
M01_L12:
       test      edi,edi
       jne       short M01_L15
       xor       edi,edi
       jmp       near ptr M01_L05
M01_L13:
       xor       r8d,r8d
       xor       esi,esi
       jmp       near ptr M01_L06
M01_L14:
       xor       edx,edx
       xor       ecx,ecx
       jmp       near ptr M01_L07
M01_L15:
       call      qword ptr [7F41C2877ED0]
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 403
```

