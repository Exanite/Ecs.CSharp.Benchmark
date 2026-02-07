## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithTwoComponents.Exanite()
       mov       rsi,[rdi+88]
       jmp       qword ptr [7FB7211E4DC8]; Ecs.CSharp.Benchmark.SystemWithTwoComponents.UpdateExaniteQuery(Exanite.Myriad.Ecs.IArchetypeView)
; Total bytes of code 13
```
```assembly
; Ecs.CSharp.Benchmark.SystemWithTwoComponents.UpdateExaniteQuery(Exanite.Myriad.Ecs.IArchetypeView)
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
       mov       rdi,rsi
       mov       rax,offset MT_Exanite.Myriad.Ecs.Queries.QueryView
       cmp       [rdi],rax
       jne       near ptr M01_L13
       cmp       byte ptr [rdi+40],0
       je        near ptr M01_L11
       lea       rax,[rdi+40]
       cmp       byte ptr [rax],0
       je        near ptr M01_L10
       mov       eax,[rax+20]
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+8]
       xor       edx,edx
       test      rcx,rcx
       je        short M01_L00
       mov       edx,[rcx+10]
       mov       rcx,[rcx+8]
       cmp       [rcx+8],edx
       jb        near ptr M01_L12
M01_L00:
       cmp       eax,edx
       jl        near ptr M01_L11
       add       rdi,40
       add       rdi,8
       mov       rbx,[rdi+8]
M01_L01:
       xor       r15d,r15d
       xor       r14d,r14d
       test      rbx,rbx
       je        short M01_L02
       mov       r14d,[rbx+10]
       mov       r15,[rbx+8]
       cmp       [r15+8],r14d
       jb        near ptr M01_L12
       add       r15,10
M01_L02:
       xor       eax,eax
       cmp       eax,r14d
       jl        short M01_L05
M01_L03:
       add       rsp,28
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       inc       eax
       cmp       eax,r14d
       jge       short M01_L03
M01_L05:
       mov       rcx,[r15+rax*8]
       mov       rdx,[rcx+18]
       mov       edi,[rcx+10]
       test      rdx,rdx
       je        near ptr M01_L14
       cmp       [rdx+8],edi
       jb        near ptr M01_L17
M01_L06:
       test      edi,edi
       je        short M01_L04
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
       je        near ptr M01_L15
       lea       r8,[rsi+10]
       mov       esi,[rsi+8]
M01_L07:
       cmp       r9d,2
       jbe       near ptr M01_L18
       mov       ecx,[rcx+18]
       cmp       ecx,r10d
       jae       near ptr M01_L18
       mov       rcx,[rdx+rcx*8+10]
       test      rcx,rcx
       je        near ptr M01_L16
       lea       rdx,[rcx+10]
       mov       ecx,[rcx+8]
M01_L08:
       cmp       esi,edi
       jl        near ptr M01_L04
       cmp       ecx,edi
       jl        near ptr M01_L04
       test      edi,edi
       jle       near ptr M01_L04
       xor       ecx,ecx
       nop       dword ptr [rax+rax]
M01_L09:
       lea       rsi,[r8+rcx]
       lea       r9,[rdx+rcx]
       inc       dword ptr [rsi]
       inc       dword ptr [r9]
       add       rcx,4
       dec       edi
       jne       short M01_L09
       jmp       near ptr M01_L04
M01_L10:
       call      qword ptr [7FB721097150]
       int       3
M01_L11:
       lea       rsi,[rbp-38]
       call      qword ptr [7FB7211E4F30]; Exanite.Myriad.Ecs.Queries.QueryView.GetArchetypeMatchResultCold()
       mov       rbx,[rbp-30]
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7FB71B82F5E8]
       int       3
M01_L13:
       mov       r11,7FB71A841858
       call      qword ptr [r11]
       mov       r15,rax
       mov       r14d,edx
       jmp       near ptr M01_L02
M01_L14:
       test      edi,edi
       jne       short M01_L17
       xor       edi,edi
       jmp       near ptr M01_L06
M01_L15:
       xor       r8d,r8d
       xor       esi,esi
       jmp       near ptr M01_L07
M01_L16:
       xor       edx,edx
       xor       ecx,ecx
       jmp       near ptr M01_L08
M01_L17:
       call      qword ptr [7FB71BC67ED0]
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 494
```

