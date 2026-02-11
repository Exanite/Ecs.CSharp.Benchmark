using BenchmarkDotNet.Attributes;
using Ecs.CSharp.Benchmark.Contexts;
using Ecs.CSharp.Benchmark.Contexts.Exanite_Components;
using Exanite.Engine.Ecs.Queries;

namespace Ecs.CSharp.Benchmark
{
    [CachedQueries(true)]
    public partial class SystemWithTwoComponentsMultipleComposition
    {
        [Context]
        private readonly ExaniteContext _exanite;

        private sealed class ExaniteContext : ExaniteBaseContext
        {
            public ExaniteContext(int entityCount)
            {
                for (int i = 0; i < entityCount; i++)
                {
                    var entity = CommandBuffer.Create()
                        .Set(new Component1())
                        .Set(new Component2() { Value = 2 });

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

                CommandBuffer.Execute();
            }
        }

        [Benchmark]
        [BenchmarkCategory(Categories.Exanite, Categories.SingleThreaded)]
        public void Exanite()
        {
            UpdateExaniteQuery();
        }

        [Query]
        private void UpdateExanite(ref Component1 component1, ref Component2 component2)
        {
            component1.Value += component2.Value;
        }
    }
}
