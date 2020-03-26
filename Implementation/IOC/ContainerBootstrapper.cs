using Unity;
using Abstractions;

namespace ThinkingNumbers_Logic.IOC
{
    public class ContainerBootstrapper
    {
        public static void RegisterTypes(ref IUnityContainer container)
        {
            //container.RegisterType<IPuzzle, Series.SeriesPuzzle>("SeriesPuzzle");
            //container.RegisterType<IKeyGen, Series.SeriesKeyGen>("SeriesKeyGen");
        }
    }
}