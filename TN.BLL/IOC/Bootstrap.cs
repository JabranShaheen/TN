using Unity;
using TN.Abstractions.BLL.PuzzleManager;
using TN.Abstractions.BLL.PuzzleBuilder;
using TN.Abstractions.BLL.PuzzleBatchBuilder;
using TN.Abstractions.BLL.PuzzleKeyBuilder;
using TN.BLL.PuzzleBatchBuilder;
using TN.BLL.PuzzleBuilder;
using TN.BLL.PuzzleKeyBuilder;
using TN.Logic.PuzzleKeyBuilder;
using TN.BLL.PuzzleManager;
using Unity.Lifetime;
using Unity.Injection;

namespace TN.Logic.IOC
{
    public static class Bootstrap
    {
        public static void Register(UnityContainer container)
        {            
            container.RegisterType<IPuzzleKeyBuilder<int, string>, StandardPuzzleKeyBuilder>();
            container.RegisterType<IPuzzleKeyBuilderDirector, PuzzleKeyBuilderDirector>();
            container.RegisterType<IPuzzleBuilder<int>, NumberSeriesPuzzleBuilder>();
            container.RegisterType<IPuzzleBuilderDirector, PuzzleBuilderDirector>();
            container.RegisterType<IPuzzleManager<int>, NumberSeriesPuzzleManager>(new ContainerControlledLifetimeManager());
            container.RegisterType<IPuzzleBatchBuilder<int>, NumberPuzzleBatchBuilder>(new InjectionConstructor(container.Resolve<IPuzzleManager<int>>(), 1000));
            container.RegisterType<IPuzzleBatchBuilderDirector, PuzzleBatchBuilderDirector>(new ContainerControlledLifetimeManager());            
        }
    }
}