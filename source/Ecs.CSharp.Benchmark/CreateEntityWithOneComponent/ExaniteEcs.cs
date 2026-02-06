using BenchmarkDotNet.Attributes;
using Ecs.CSharp.Benchmark.Contexts;
using Ecs.CSharp.Benchmark.Contexts.Exanite_Components;

namespace Ecs.CSharp.Benchmark
{
    public partial class CreateEntityWithOneComponent
    {
        [Context]
        private readonly ExaniteBaseContext _exanite;

        [Benchmark]
        [BenchmarkCategory(Categories.Exanite, Categories.SingleThreaded)]
        public void Exanite()
        {
            for (int i = 0; i < EntityCount; ++i)
            {
                _exanite.CommandBuffer.Create()
                    .Set(new Component1());
            }

            _exanite.CommandBuffer.Execute();
        }
    }
}
