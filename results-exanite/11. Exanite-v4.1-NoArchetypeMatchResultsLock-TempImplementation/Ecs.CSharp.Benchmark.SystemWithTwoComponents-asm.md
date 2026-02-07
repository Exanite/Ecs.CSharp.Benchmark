## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithTwoComponents.Exanite()
       mov       rsi,[rdi+88]
       jmp       qword ptr [7F1C07FD5818]; Ecs.CSharp.Benchmark.SystemWithTwoComponents.UpdateExaniteQuery(Exanite.Myriad.Ecs.IArchetypeView)
; Total bytes of code 13
```
```assembly
; Ecs.CSharp.Benchmark.SystemWithTwoComponents.UpdateExaniteQuery(Exanite.Myriad.Ecs.IArchetypeView)
       push      rbp
       push      r15
       push      rbx
       sub       rsp,20
       lea       rbp,[rsp+30]
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-30],ymm8
       mov       rdi,rsi
       mov       rsi,offset MT_Exanite.Myriad.Ecs.Queries.QueryView
       cmp       [rdi],rsi
       jne       near ptr M01_L09
       lea       rsi,[rbp-30]
       call      qword ptr [7F1C07FD58F0]; Exanite.Myriad.Ecs.Queries.QueryView.GetArchetypeMatchResult()
       mov       rax,[rbp-28]
       xor       ebx,ebx
       xor       r15d,r15d
       test      rax,rax
       je        short M01_L00
       mov       r15d,[rax+10]
       mov       rbx,[rax+8]
       cmp       [rbx+8],r15d
       jb        near ptr M01_L08
       add       rbx,10
M01_L00:
       xor       eax,eax
       cmp       eax,r15d
       jl        short M01_L03
M01_L01:
       add       rsp,20
       pop       rbx
       pop       r15
       pop       rbp
       ret
M01_L02:
       inc       eax
       cmp       eax,r15d
       jge       short M01_L01
M01_L03:
       mov       rcx,[rbx+rax*8]
       mov       rdx,[rcx+18]
       mov       edi,[rcx+10]
       test      rdx,rdx
       je        near ptr M01_L10
       cmp       [rdx+8],edi
       jb        near ptr M01_L13
M01_L04:
       test      edi,edi
       je        short M01_L02
       mov       rdx,[rcx+20]
       mov       rsi,rdx
       mov       rcx,[rcx+40]
       mov       r8,rcx
       mov       r9d,[r8+8]
       cmp       r9d,1
       jbe       near ptr M01_L14
       mov       r8d,[r8+14]
       mov       r10d,[rsi+8]
       cmp       r8d,r10d
       jae       near ptr M01_L14
       mov       rsi,[rsi+r8*8+10]
       test      rsi,rsi
       je        near ptr M01_L11
       lea       r8,[rsi+10]
       mov       esi,[rsi+8]
M01_L05:
       cmp       r9d,2
       jbe       near ptr M01_L14
       mov       ecx,[rcx+18]
       cmp       ecx,r10d
       jae       near ptr M01_L14
       mov       rcx,[rdx+rcx*8+10]
       test      rcx,rcx
       je        short M01_L12
       nop       dword ptr [rax]
       lea       rdx,[rcx+10]
       mov       ecx,[rcx+8]
M01_L06:
       cmp       esi,edi
       jl        near ptr M01_L02
       cmp       ecx,edi
       jl        near ptr M01_L02
       test      edi,edi
       jle       near ptr M01_L02
       xor       ecx,ecx
       nop       word ptr [rax+rax]
M01_L07:
       lea       rsi,[r8+rcx]
       lea       r9,[rdx+rcx]
       inc       dword ptr [rsi]
       inc       dword ptr [r9]
       add       rcx,4
       dec       edi
       jne       short M01_L07
       jmp       near ptr M01_L02
M01_L08:
       call      qword ptr [7F1C0263F5E8]
       int       3
M01_L09:
       mov       r11,7F1C01651A98
       call      qword ptr [r11]
       mov       rbx,rax
       mov       r15d,edx
       jmp       near ptr M01_L00
M01_L10:
       test      edi,edi
       jne       short M01_L13
       xor       edi,edi
       jmp       near ptr M01_L04
M01_L11:
       xor       r8d,r8d
       xor       esi,esi
       jmp       near ptr M01_L05
M01_L12:
       xor       edx,edx
       xor       ecx,ecx
       jmp       short M01_L06
M01_L13:
       call      qword ptr [7F1C02A77ED0]
       int       3
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 385
```

