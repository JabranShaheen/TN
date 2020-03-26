using System.Collections.Generic;
using TN.Abstractions.Entities;

namespace TN.Abstractions.BLL.PuzzleManager
{
    public interface IPuzzleManager<PuzzleDataType>
    {
        Puzzle<PuzzleDataType> ConstructPuzzle();
    }
}
