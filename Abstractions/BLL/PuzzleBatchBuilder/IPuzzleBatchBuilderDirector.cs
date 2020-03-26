using System;
using System.Collections.Generic;
using System.Text;

namespace TN.Abstractions.BLL.PuzzleBatchBuilder
{
    public interface IPuzzleBatchBuilderDirector
    {
        void BuildPuzzleBatch<PuzzleDataType>(IPuzzleBatchBuilder<PuzzleDataType> puzzleBatchBuilder);
    }
}
