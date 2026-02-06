#pragma warning disable CA1852 // Seal internal types

using System.Globalization;
using System.Linq;
using BenchmarkDotNet.Configs;
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

    typeof(SystemWithOneComponent),
    typeof(SystemWithTwoComponents),
    typeof(SystemWithThreeComponents),

    typeof(SystemWithTwoComponentsMultipleComposition)
});

IConfig configuration = DefaultConfig.Instance
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
    .WithOrderer(new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest))
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
