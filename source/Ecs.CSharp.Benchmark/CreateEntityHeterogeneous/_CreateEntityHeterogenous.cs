using BenchmarkDotNet.Attributes;

namespace Ecs.CSharp.Benchmark
{
    [BenchmarkCategory(Categories.CreateEntity)]
    [MemoryDiagnoser]
    public partial class CreateEntityHeterogeneous
    {
        [Params(100000)]
        public int EntityCount { get; set; }

        [IterationSetup]
        public void Setup() => BenchmarkOperations.SetupContexts(this);

        [IterationCleanup]
        public void Cleanup() => BenchmarkOperations.CleanupContexts(this);
    }
}
