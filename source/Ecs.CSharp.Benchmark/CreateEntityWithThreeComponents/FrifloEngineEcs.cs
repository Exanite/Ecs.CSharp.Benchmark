using BenchmarkDotNet.Attributes;
using Ecs.CSharp.Benchmark.Contexts.FrifloEngine_Components;
using Friflo.Engine.ECS;

namespace Ecs.CSharp.Benchmark
{
    public partial class CreateEntityWithThreeComponents
    {
        [Benchmark]
        [BenchmarkCategory(Categories.FrifloEngineEcs, Categories.SingleThreaded)]
        public void FrifloEngineEcs()
        {
            EntityStore store = new EntityStore(PidType.UsePidAsId);
            store.EnsureCapacity(EntityCount);

            Archetype archetype = store.GetArchetype(ComponentTypes.Get<Component1, Component2, Component3>());
            archetype.EnsureCapacity(EntityCount);

            for (int i = 0; i < EntityCount; ++i)
            {
                archetype.CreateEntity();
            }
        }
    }
}
