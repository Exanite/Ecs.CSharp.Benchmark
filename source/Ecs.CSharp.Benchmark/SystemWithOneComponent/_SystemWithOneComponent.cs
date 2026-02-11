using BenchmarkDotNet.Attributes;

namespace Ecs.CSharp.Benchmark
{
    [BenchmarkCategory(Categories.System)]
    public partial class SystemWithOneComponent
    {
        [Params(100000)]
        public int EntityCount { get; set; }

        [Params(0, 10)]
        public int EntityPadding { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            BenchmarkOperations.SetupContexts(this, EntityCount, EntityPadding);

            // Initialize query for Exanite
            InitializeQueries([_exanite.World]);
        }

        [GlobalCleanup]
        public void Cleanup() => BenchmarkOperations.CleanupContexts(this);
    }
}
