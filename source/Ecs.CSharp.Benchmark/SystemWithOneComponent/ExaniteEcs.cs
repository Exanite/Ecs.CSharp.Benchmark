using BenchmarkDotNet.Attributes;
using Ecs.CSharp.Benchmark.Contexts;
using Ecs.CSharp.Benchmark.Contexts.Exanite_Components;
using Exanite.Engine.Ecs.Queries;

namespace Ecs.CSharp.Benchmark
{
    public partial class SystemWithOneComponent
    {
        [Context]
        private readonly ExaniteContext _exanite;

        private sealed class ExaniteContext : ExaniteBaseContext
        {
            public ExaniteContext(int entityCount, int _) : base()
            {
                for (int i = 0; i < entityCount; i++)
                {
                    CommandBuffer.Create().Set(new Component1());
                }

                CommandBuffer.Execute();
            }
        }

        [BenchmarkCategory(Categories.Exanite)]
        [Benchmark]
        public void Exanite()
        {
            UpdateExaniteQuery([_exanite.World]);
        }

        [Query]
        private void UpdateExanite(ref Component1 component1)
        {
            component1.Value++;
        }
    }
}
