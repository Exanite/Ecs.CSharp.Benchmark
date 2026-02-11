#pragma warning disable CA1852 // Seal internal types

using System;
using System.Globalization;
using System.Linq;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Filters;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using Ecs.CSharp.Benchmark;

CultureInfo cultureInfo = new("en-US");

CultureInfo.CurrentCulture = cultureInfo;
CultureInfo.CurrentUICulture = cultureInfo;
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

BenchmarkSwitcher benchmark = BenchmarkSwitcher.FromTypes(new[]
{
    typeof(CreateEntityWithOneComponent),
    typeof(CreateEntityWithTwoComponents),
    typeof(CreateEntityWithThreeComponents),
    typeof(CreateEntityHeterogeneous),

    typeof(SystemWithOneComponent),
    typeof(SystemWithTwoComponents),
    typeof(SystemWithThreeComponents),

    typeof(SystemWithTwoComponentsMultipleComposition),
});

IConfig configuration = DefaultConfig.Instance
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
    .WithOrderer(new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest))
    .AddHardwareCounters(
        HardwareCounter.CacheMisses,
        HardwareCounter.LlcMisses,
        HardwareCounter.LlcReference,
        HardwareCounter.BranchMispredictions,
        HardwareCounter.InstructionRetired)
    .AddDiagnoser(new MemoryDiagnoser(new MemoryDiagnoserConfig()))
    // .AddDiagnoser(new DisassemblyDiagnoser(new DisassemblyDiagnoserConfig()))
    .AddFilter(new SimpleFilter(benchmarkCase =>
    {
        // Skip non-zero entity padding
        if (benchmarkCase.Parameters.Items.Any(a => a.Name == "EntityPadding" && (int)a.Value != 0))
        {
            return false;
        }

        // Skip multithreaded
        if (benchmarkCase.Descriptor.HasCategory(Categories.MultiThreaded))
        {
            return false;
        }

        // Skip SIMD
        if (benchmarkCase.Descriptor.HasCategory(Categories.Simd))
        {
            return false;
        }

        // Exanite only
        if (!benchmarkCase.Descriptor.HasCategory(Categories.Exanite))
        {
            return false;
        }

        if (!benchmarkCase.Descriptor.Type.Name.Contains("CreateEntity", StringComparison.Ordinal))
        {
            return false;
        }

        return true;
    }));

if (args.Length > 0)
{
    benchmark.Run(args, configuration);
}
else
{
    benchmark.RunAll(configuration);
}
