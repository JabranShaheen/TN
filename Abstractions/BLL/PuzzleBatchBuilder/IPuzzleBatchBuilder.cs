using System.Collections.Generic;
using TN.Abstractions.Entities;

namespace TN.Abstractions.BLL.PuzzleBatchBuilder
{
    public interface IPuzzleBatchBuilder <PuzzleDataType>
    {
        void BuildPuzzleBatch();
        IEnumerable<Puzzle<PuzzleDataType>> GetPuzzleBatch();
    }
}
