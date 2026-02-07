## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithThreeComponents.Exanite()
       mov       rsi,[rdi+88]
       jmp       qword ptr [7F503EACF798]; Ecs.CSharp.Benchmark.SystemWithThreeComponents.UpdateExaniteQuery(Exanite.Myriad.Ecs.IArchetypeView)
; Total bytes of code 13
```
```assembly
; Ecs.CSharp.Benchmark.SystemWithThreeComponents.UpdateExaniteQuery(Exanite.Myriad.Ecs.IArchetypeView)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       rdi,rsi
       mov       rsi,offset MT_Exanite.Myriad.Ecs.Queries.QueryView
       cmp       [rdi],rsi
       jne       near ptr M01_L12
       mov       rsi,[rdi+8]
       mov       eax,[rsi+20]
       mov       rcx,[rdi+18]
       cmp       eax,[rcx+60]
       jne       near ptr M01_L10
M01_L00:
       mov       rax,[rsi+8]
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
       add       rsp,8
       pop       rbx
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
       test      rdx,rdx
       je        near ptr M01_L13
       cmp       [rdx+8],edi
       jb        near ptr M01_L17
M01_L05:
       test      edi,edi
       je        short M01_L03
       mov       rdx,[rcx+20]
       mov       rsi,rdx
       mov       rcx,[rcx+40]
       mov       r8,rcx
       mov       r9d,[r8+8]
       cmp       r9d,1
       jbe       near ptr M01_L18
       mov       r8d,[r8+14]
       mov       r10d,[rsi+8]
       cmp       r8d,r10d
       jae       near ptr M01_L18
       mov       rsi,[rsi+r8*8+10]
       test      rsi,rsi
       je        near ptr M01_L14
       lea       r8,[rsi+10]
       mov       esi,[rsi+8]
M01_L06:
       mov       r11,rdx
       mov       r14,rcx
       cmp       r9d,2
       jbe       near ptr M01_L18
       mov       r14d,[r14+18]
       cmp       r14d,r10d
       jae       near ptr M01_L18
       mov       r11,[r11+r14*8+10]
       test      r11,r11
       je        near ptr M01_L15
       lea       r14,[r11+10]
       mov       r11d,[r11+8]
M01_L07:
       cmp       r9d,3
       jbe       near ptr M01_L18
       mov       ecx,[rcx+1C]
       cmp       ecx,r10d
       jae       near ptr M01_L18
       mov       rcx,[rdx+rcx*8+10]
       test      rcx,rcx
       je        near ptr M01_L16
       lea       rdx,[rcx+10]
       mov       ecx,[rcx+8]
M01_L08:
       cmp       esi,edi
       jl        near ptr M01_L03
       cmp       r11d,edi
       jl        near ptr M01_L03
       cmp       ecx,edi
       jl        near ptr M01_L03
       test      edi,edi
       jle       near ptr M01_L03
       xor       ecx,ecx
M01_L09:
       lea       rsi,[r8+rcx]
       lea       r9,[r14+rcx]
       lea       r10,[rdx+rcx]
       mov       r11d,[rsi]
       add       r11d,[r9]
       add       r11d,[r10]
       mov       [rsi],r11d
       add       rcx,4
       dec       edi
       jne       short M01_L09
       jmp       near ptr M01_L03
M01_L10:
       call      qword ptr [7F503EACF8B8]; Exanite.Myriad.Ecs.Queries.QueryView.GetMatchResultCold(Exanite.Myriad.Ecs.Queries.QueryView, MatchResult)
       mov       rsi,rax
       jmp       near ptr M01_L00
M01_L11:
       call      qword ptr [7F503904F5E8]
       int       3
M01_L12:
       mov       r11,7F5038061D50
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r15d,edx
       jmp       near ptr M01_L01
M01_L13:
       test      edi,edi
       jne       short M01_L17
       xor       edi,edi
       jmp       near ptr M01_L05
M01_L14:
       xor       r8d,r8d
       xor       esi,esi
       jmp       near ptr M01_L06
M01_L15:
       xor       r14d,r14d
       xor       r11d,r11d
       jmp       near ptr M01_L07
M01_L16:
       xor       edx,edx
       xor       ecx,ecx
       jmp       near ptr M01_L08
M01_L17:
       call      qword ptr [7F5039487ED0]
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 479
```

