using BenchmarkDotNet.Attributes;
using Ecs.CSharp.Benchmark.Contexts;
using Ecs.CSharp.Benchmark.Contexts.Exanite_Components;

namespace Ecs.CSharp.Benchmark
{
    public partial class CreateEntityHeterogeneous
    {
        [Context]
        private readonly ExaniteBaseContext _exanite;

        [Benchmark]
        [BenchmarkCategory(Categories.Exanite, Categories.SingleThreaded)]
        public void Exanite()
        {
            for (int i = 0; i < EntityCount; ++i)
            {
                var entity = _exanite.CommandBuffer.Create()
                    .Set(new Component1());

                switch (i % 4)
                {
                    case 0:
                        entity.Set(new Padding1());
                        break;

                    case 1:
                        entity.Set(new Padding2());
                        break;

                    case 2:
                        entity.Set(new Padding3());
                        break;

                    case 3:
                        entity.Set(new Padding4());
                        break;
                }

            }

            _exanite.CommandBuffer.Execute();
        }
    }
}
