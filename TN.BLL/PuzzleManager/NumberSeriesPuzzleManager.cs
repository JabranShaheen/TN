using System.Collections.Generic;
using TN.Abstractions.BLL.PuzzleBuilder;
using TN.Abstractions.BLL.PuzzleManager;
using TN.Abstractions.Entities;

namespace TN.BLL.PuzzleManager
{
    class NumberSeriesPuzzleManager : IPuzzleManager<int>
    {

        IPuzzleBuilderDirector _puzzleBuilderDirector;
        IPuzzleBuilder<int> _puzzleBuilder;


        public NumberSeriesPuzzleManager(
                                            IPuzzleBuilderDirector puzzleBuilderDirector,
                                            IPuzzleBuilder<int> puzzleBuilder
                                        )
        {
            _puzzleBuilderDirector = puzzleBuilderDirector;
            _puzzleBuilder = puzzleBuilder;
        }


        public Puzzle<int> ConstructPuzzle()
        {
            _puzzleBuilderDirector.BuilPuzzle(_puzzleBuilder);
            return _puzzleBuilder.GetPuzzle();
        }
    }
}