//using TN.Logic.PuzzleBuilder.StandardSeries;
//using TN.Abstractions.BLL;
using Unity;
//using TN.Logic.BLL;
//using TN.Abstractions;
//using TN.Logic.PuzzleList;

namespace TN.Logic.IOC
{
    public static class Bootstrap
    {
        public static void Register(UnityContainer container)
        {

            //IPuzzleKeyBuilder standardSeriesPuzzleKeyBuilder = new StandardSeriesPuzzleKeyBuilder();
            //IPuzzleKeyBuilderDirector PuzzleKeyBuilderDirector = new PuzzleKeyBuilderDirector();            

            //IPuzzleBuilder seriesPuzzleBuilder = new StandardSeriesPuzzleBuilder(PuzzleKeyBuilderDirector, standardSeriesPuzzleKeyBuilder);
            //IPuzzleBuilderDirector puzzleBuilderDirector = new PuzzleBuilderDirector();

            //IPuzzleListBuilder seriesPuzzleListBuilder = new PuzzleListBuilder(puzzleBuilderDirector, seriesPuzzleBuilder);
            //IPuzzleListDirector puzzleListDirector = new PuzzleListDirector();

            //container.RegisterInstance<IPuzzleListBuilder>("PuzzleListBuilder", seriesPuzzleListBuilder);
            //container.RegisterInstance<IPuzzleListDirector>("PuzzleListDirector", puzzleListDirector);

        }
    }
}