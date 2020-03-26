using System.Collections.Generic;
using TN.Abstractions.Entities;

namespace TN.Abstractions.BLL.PuzzleBatchBuilder
{
    public interface IPuzzleBatchBuilder
    {
        void BuildPuzzleBatch();
        List<Puzzle<object>> GetPuzzleBatch();
    }
}
