using System;
using Exanite.Myriad.Ecs;
using Exanite.Myriad.Ecs.CommandBuffers;

namespace Ecs.CSharp.Benchmark.Contexts
{
    namespace ExaniteEcs_Components
    {
        internal struct Component1 : IComponent
        {
            public int Value;
        }

        internal struct Component2 : IComponent
        {
            public int Value;
        }

        internal struct Component3 : IComponent
        {
            public int Value;
        }

        internal struct Padding1 : IComponent;
        internal struct Padding2 : IComponent;
        internal struct Padding3 : IComponent;
        internal struct Padding4 : IComponent;
    }

    internal class ExaniteEcsBaseContext : IDisposable
    {
        public EcsWorld World { get; }
        public EcsCommandBuffer CommandBuffer { get; }

        public ExaniteEcsBaseContext()
        {
            World = new EcsWorld();
            CommandBuffer = World.AcquireCommandBuffer();
        }

        public virtual void Dispose()
        {
            World.Dispose();
        }
    }
}
