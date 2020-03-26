using System;
using System.Collections.Generic;
using System.Text;
using TN.Abstractions.BLL.PuzzleBatchBuilder;

namespace TN.BLL.PuzzleBatchBuilder
{
    class PuzzleBatchBuilderDirector : IPuzzleBatchBuilderDirector
    {
        public void BuildPuzzleBatch<PuzzleDataType>(IPuzzleBatchBuilder<PuzzleDataType> puzzleBatchBuilder)
        {
            puzzleBatchBuilder.BuildPuzzleBatch();
        }
    }
}
