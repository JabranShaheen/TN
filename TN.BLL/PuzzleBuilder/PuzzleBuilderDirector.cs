using System;
using System.Collections.Generic;
using System.Text;
using TN.Abstractions.BLL.PuzzleBuilder;

namespace TN.BLL.PuzzleBuilder
{
    class PuzzleBuilderDirector : IPuzzleBuilderDirector
    {
        public void BuilPuzzle<T>(IPuzzleBuilder<T> puzzleBuilder)
        {
            puzzleBuilder.BuilPuzzle();
        }
    }
}
