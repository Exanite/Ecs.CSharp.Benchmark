using BenchmarkDotNet.Attributes;
using Ecs.CSharp.Benchmark.Contexts;
using Ecs.CSharp.Benchmark.Contexts.ExaniteEcs_Components;
using Exanite.Engine.Ecs.Queries;

namespace Ecs.CSharp.Benchmark
{
    public partial class SystemWithOneComponent
    {
        [Context]
        private readonly ExaniteEcsContext _exaniteEcs;

        private sealed class ExaniteEcsContext : ExaniteEcsBaseContext
        {
            public ExaniteEcsContext(int entityCount, int _) : base()
            {
                for (int i = 0; i < entityCount; i++)
                {
                    CommandBuffer.Create().Set(new Component1());
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
        private void ExaniteEcsQuery(ref Component1 component1)
        {
            component1.Value++;
        }
    }
}
