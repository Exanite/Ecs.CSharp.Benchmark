using BenchmarkDotNet.Attributes;
using Ecs.CSharp.Benchmark.Contexts;
using Ecs.CSharp.Benchmark.Contexts.ExaniteEcs_Components;

namespace Ecs.CSharp.Benchmark
{
    public partial class CreateEntityWithTwoComponents
    {
        [Context]
        private readonly ExaniteEcsBaseContext _exaniteEcs;

        [BenchmarkCategory(Categories.ExaniteEcs)]
        [Benchmark]
        public void ExaniteEcs()
        {
            for (int i = 0; i < EntityCount; ++i)
            {
                _exaniteEcs.CommandBuffer.Create()
                    .Set(new Component1())
                    .Set(new Component2());
            }

            _exaniteEcs.CommandBuffer.Execute();
        }
    }
}
