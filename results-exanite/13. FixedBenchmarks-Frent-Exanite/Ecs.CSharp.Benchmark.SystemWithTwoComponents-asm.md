## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithTwoComponents.Frent_QueryDelegate()
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
       mov       rdi,7F6968C031F8
       mov       r15,[rdi]
       test      r15,r15
       je        near ptr M00_L10
M00_L00:
       cmp       [rbx],bl
       add       rbx,10
       mov       r14,[rbx]
       cmp       [r14],r14b
       add       r14,10
       mov       ebx,[rbx+8]
       xor       r13d,r13d
       mov       rsi,offset Ecs.CSharp.Benchmark.SystemWithTwoComponents+<>c.<Frent_QueryDelegate>b__31_0(Component1 ByRef, Component2 ByRef)
       cmp       [r15+18],rsi
       jne       near ptr M00_L08
M00_L01:
       cmp       r13d,ebx
       jge       near ptr M00_L09
       mov       esi,r13d
       mov       rsi,[r14+rsi*8]
       mov       rdx,[rsi+18]
       mov       rdi,rdx
       cmp       [rdi],dil
       movzx     eax,byte ptr [rdi+11]
       and       eax,7F
       mov       rcx,[rsi+8]
       mov       r8,rcx
       cmp       [r8],r8b
       movsxd    rdi,eax
       mov       rax,[r8+rdi*8+10]
       mov       r15,[rax+8]
       cmp       [r15],r15b
       add       r15,10
       cmp       [rdx],dl
       movzx     edi,byte ptr [rdx+12]
       and       edi,7F
       cmp       [rcx],cl
       movsxd    r8,edi
       mov       rdx,[rcx+r8*8+10]
       mov       r12,[rdx+8]
       cmp       [r12],r12b
       add       r12,10
       mov       esi,[rsi+20]
       mov       edi,esi
       test      edi,edi
       jl        short M00_L03
M00_L02:
       mov       ecx,[r12]
       add       [r15],ecx
       add       r15,4
       add       r12,4
       dec       edi
       jns       short M00_L02
M00_L03:
       inc       r13d
       jmp       short M00_L01
M00_L04:
       mov       edi,r13d
       mov       rsi,[r14+rdi*8]
       mov       rdx,[rsi+18]
       mov       rdi,rdx
       cmp       [rdi],dil
       movzx     eax,byte ptr [rdi+11]
       and       eax,7F
       mov       rcx,[rsi+8]
       mov       r8,rcx
       cmp       [r8],r8b
       movsxd    rdi,eax
       mov       rdi,[r8+rdi*8+10]
       mov       rdi,[rdi+8]
       cmp       [rdi],dil
       add       rdi,10
       mov       r12,rdi
       cmp       [rdx],dl
       movzx     edi,byte ptr [rdx+12]
       and       edi,7F
       cmp       [rcx],cl
       movsxd    rdx,edi
       mov       rdx,[rcx+rdx*8+10]
       mov       rdx,[rdx+8]
       cmp       [rdx],dl
       add       rdx,10
       mov       rax,rdx
       mov       edi,[rsi+20]
       mov       ecx,edi
       mov       [rbp-2C],ecx
       test      ecx,ecx
       jl        short M00_L07
M00_L05:
       mov       rsi,offset Ecs.CSharp.Benchmark.SystemWithTwoComponents+<>c.<Frent_QueryDelegate>b__31_0(Component1 ByRef, Component2 ByRef)
       cmp       [r15+18],rsi
       jne       near ptr M00_L11
       mov       esi,[rax]
       add       [r12],esi
M00_L06:
       add       r12,4
       add       rax,4
       mov       ecx,[rbp-2C]
       dec       ecx
       mov       [rbp-2C],ecx
       jns       short M00_L05
M00_L07:
       inc       r13d
M00_L08:
       cmp       r13d,ebx
       jl        near ptr M00_L04
M00_L09:
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       mov       rdi,offset MT_Frent.Systems.QueryDelegates+Query<Ecs.CSharp.Benchmark.Contexts.FrentBaseContext+Component1, Ecs.CSharp.Benchmark.Contexts.FrentBaseContext+Component2>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,7F6968C031C8
       mov       rsi,[rsi]
       mov       rdi,r15
       mov       rdx,offset Ecs.CSharp.Benchmark.SystemWithTwoComponents+<>c.<Frent_QueryDelegate>b__31_0(Component1 ByRef, Component2 ByRef)
       call      qword ptr [7F90BAA56E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,7F6968C031F8
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L11:
       mov       rsi,r12
       mov       [rbp-38],rax
       mov       rdx,rax
       mov       rdi,[r15+8]
       call      qword ptr [r15+18]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L06
; Total bytes of code 490
```
```assembly
; Ecs.CSharp.Benchmark.SystemWithTwoComponents+<>c.<Frent_QueryDelegate>b__31_0(Component1 ByRef, Component2 ByRef)
       mov       eax,[rdx]
       add       [rsi],eax
       ret
; Total bytes of code 5
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
       call      qword ptr [7F90C03F6520]
       int       3
; Total bytes of code 43
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithTwoComponents.Frent_QueryInline()
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
       xor       edx,edx
       cmp       edx,eax
       jge       short M00_L03
M00_L00:
       mov       rdi,[rcx+rdx*8]
       mov       rsi,[rdi+18]
       mov       r8,rsi
       cmp       [r8],r8b
       movzx     r8d,byte ptr [r8+11]
       and       r8d,7F
       mov       r9,[rdi+8]
       mov       r10,r9
       cmp       [r10],r10b
       movsxd    r8,r8d
       mov       r8,[r10+r8*8+10]
       mov       r8,[r8+8]
       cmp       [r8],r8b
       add       r8,10
       cmp       [rsi],sil
       movzx     esi,byte ptr [rsi+12]
       and       esi,7F
       cmp       [r9],r9b
       movsxd    rsi,esi
       mov       rsi,[r9+rsi*8+10]
       mov       rsi,[rsi+8]
       cmp       [rsi],sil
       add       rsi,10
       movsxd    rdi,dword ptr [rdi+20]
       test      rdi,rdi
       jl        short M00_L02
M00_L01:
       mov       r9d,[rsi]
       add       [r8],r9d
       add       r8,4
       add       rsi,4
       dec       rdi
       jns       short M00_L01
M00_L02:
       inc       edx
       cmp       edx,eax
       jl        short M00_L00
M00_L03:
       pop       rbp
       ret
; Total bytes of code 157
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; Ecs.CSharp.Benchmark.SystemWithTwoComponents.Exanite()
       mov       rsi,[rdi+88]
       jmp       qword ptr [7F988B1E4CA8]; Ecs.CSharp.Benchmark.SystemWithTwoComponents.UpdateExaniteQuery(Exanite.Myriad.Ecs.IArchetypeView)
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
       mov       r9d,[r9]
       add       [rsi],r9d
       add       rcx,4
       dec       edi
       jne       short M01_L09
       jmp       near ptr M01_L04
M01_L10:
       call      qword ptr [7F988B097168]
       int       3
M01_L11:
       lea       rsi,[rbp-38]
       call      qword ptr [7F988B1E4E10]; Exanite.Myriad.Ecs.Queries.QueryView.GetArchetypeMatchResultCold()
       mov       rbx,[rbp-30]
       jmp       near ptr M01_L01
M01_L12:
       call      qword ptr [7F988582F5E8]
       int       3
M01_L13:
       mov       r11,7F9884841858
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
       call      qword ptr [7F9885C67ED0]
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 495
```

