using System.Collections.Generic;
using TN.Abstractions.Entities;

namespace TN.Abstractions.BLL.PuzzleBatchOperation
{
    public interface IPuzzleBatchOperation <T>
    {
        void PerformOperation(IEnumerable<Puzzle<T>> puzzles);
    }
}
