using BenchmarkDotNet.Attributes;
using Ecs.CSharp.Benchmark.Contexts;
using Ecs.CSharp.Benchmark.Contexts.Fennecs_Components;
using fennecs;

namespace Ecs.CSharp.Benchmark
{
    public partial class CreateEntityWithTwoComponents
    {
        [Context] private readonly FennecsBaseContext _fennecs;

        [Benchmark]
        [BenchmarkCategory(Categories.Fennecs, Categories.SingleThreaded, Categories.DirectModification)]
        public void Fennecs()
        {
            World world = _fennecs.World;

            for (int i = 0; i < EntityCount; ++i)
            {
                world.Spawn().
                    Add<Component1>().Add<Component2>();
            }
        }
    }
}
