## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithThreeComponents.Exanite()
       mov       rsi,[rdi+88]
       jmp       qword ptr [7FFAC32DF720]; Ecs.CSharp.Benchmark.SystemWithThreeComponents.UpdateExaniteQuery(Exanite.Myriad.Ecs.IArchetypeView)
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
       mov       rax,offset MT_Exanite.Myriad.Ecs.Queries.QueryView
       cmp       [rdi],rax
       jne       near ptr M01_L12
       mov       rax,[rdi+8]
       mov       ecx,[rax+10]
       mov       rdx,[rdi+10]
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
       jge       near ptr M01_L09
M01_L02:
       mov       rcx,[rbx+rax*8]
       mov       rdx,[rcx+18]
       mov       edi,[rcx+10]
       mov       esi,edi
       test      rdx,rdx
       je        near ptr M01_L13
       cmp       [rdx+8],esi
       jb        near ptr M01_L17
M01_L03:
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
M01_L04:
       mov       r9,rdx
       mov       r14,rcx
       cmp       r10d,2
       jbe       near ptr M01_L18
       mov       r14d,[r14+18]
       cmp       r14d,r11d
       jae       near ptr M01_L18
       mov       r9,[r9+r14*8+10]
       mov       r14d,edi
       test      r9,r9
       je        near ptr M01_L15
       cmp       [r9+8],r14d
       jb        near ptr M01_L17
       add       r9,10
M01_L05:
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
M01_L06:
       xor       edx,edx
       test      esi,esi
       jle       short M01_L08
M01_L07:
       movsxd    rdi,edx
       lea       r10,[r8+rdi*4]
       mov       r11d,[r10]
       add       r11d,[r9+rdi*4]
       add       r11d,[rcx+rdi*4]
       mov       [r10],r11d
       inc       edx
       cmp       edx,esi
       jl        short M01_L07
M01_L08:
       inc       eax
       cmp       eax,r15d
       jl        near ptr M01_L02
M01_L09:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      qword ptr [7FFAC32DF8D0]; Exanite.Myriad.Ecs.Queries.QueryView.GetMatchResultCold(Exanite.Myriad.Ecs.Queries.QueryView)
       jmp       near ptr M01_L00
M01_L11:
       call      qword ptr [7FFABD85F5E8]
       int       3
M01_L12:
       mov       r11,7FFABC871F60
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r15d,edx
       jmp       near ptr M01_L01
M01_L13:
       test      esi,esi
       jne       short M01_L17
       xor       esi,esi
       jmp       near ptr M01_L03
M01_L14:
       test      r9d,r9d
       jne       short M01_L17
       xor       r8d,r8d
       jmp       near ptr M01_L04
M01_L15:
       test      r14d,r14d
       jne       short M01_L17
       xor       r9d,r9d
       jmp       near ptr M01_L05
M01_L16:
       test      edi,edi
       jne       short M01_L17
       xor       ecx,ecx
       jmp       near ptr M01_L06
M01_L17:
       call      qword ptr [7FFABDC97ED0]
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 475
```

