using BenchmarkDotNet.Attributes;

namespace Ecs.CSharp.Benchmark
{
    [BenchmarkCategory(Categories.System)]
    public partial class SystemWithTwoComponentsMultipleComposition
    {
        [Params(100000)]
        public int EntityCount { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            BenchmarkOperations.SetupContexts(this, EntityCount);

            // Initialize query for Exanite
            InitializeQueries([_exanite.World]);
        }

        [GlobalCleanup]
        public void Cleanup() => BenchmarkOperations.CleanupContexts(this);
    }
}
