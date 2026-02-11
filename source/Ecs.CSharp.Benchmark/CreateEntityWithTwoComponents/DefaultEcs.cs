using BenchmarkDotNet.Attributes;
using DefaultEcs;
using Ecs.CSharp.Benchmark.Contexts;

namespace Ecs.CSharp.Benchmark
{
    public partial class CreateEntityWithTwoComponents
    {
        [Context]
        private readonly DefaultEcsBaseContext _defaultEcs;

        [Benchmark]
        [BenchmarkCategory(Categories.DefaultEcs, Categories.SingleThreaded, Categories.DirectModification)]
        public void DefaultEcs()
        {
            for (int i = 0; i < EntityCount; ++i)
            {
                Entity entity = _defaultEcs.World.CreateEntity();
                entity.Set<DefaultEcsBaseContext.Component1>();
                entity.Set<DefaultEcsBaseContext.Component2>();
            }
        }
    }
}
