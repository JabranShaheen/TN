using System.Collections.Generic;
using TN.Abstractions.Entities;

namespace TN.Abstractions.BLL.PuzzleBatchOperation
{
    interface IPuzzleBatchOperationSet
    {
        void ApplyPuzzleBatchOperations<PuzzleDataType>(IEnumerable<IPuzzleBatchOperation<Puzzle<PuzzleDataType>>> puzzleBatchOperations);
    }
}