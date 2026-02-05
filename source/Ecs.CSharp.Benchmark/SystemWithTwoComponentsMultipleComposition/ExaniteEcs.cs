using BenchmarkDotNet.Attributes;
using Ecs.CSharp.Benchmark.Contexts;
using Ecs.CSharp.Benchmark.Contexts.ExaniteEcs_Components;
using Exanite.Engine.Ecs.Queries;

namespace Ecs.CSharp.Benchmark
{
    public partial class SystemWithTwoComponentsMultipleComposition
    {
        [Context]
        private readonly ExaniteEcsContext _exaniteEcs;

        private sealed class ExaniteEcsContext : ExaniteEcsBaseContext
        {
            public ExaniteEcsContext(int entityCount, int _) : base()
            {
                for (int i = 0; i < entityCount; i++)
                {
                    var entity = CommandBuffer.Create().Set(new Component1());

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

        [BenchmarkCategory(Categories.ExaniteEcs)]
        [Benchmark]
        public void ExaniteEcs()
        {
            ExaniteEcsQueryQuery();
        }

        [Query]
        private void ExaniteEcsQuery(ref Component1 component1, ref Component2 component2)
        {
            component1.Value++;
            component2.Value++;
        }
    }
}
