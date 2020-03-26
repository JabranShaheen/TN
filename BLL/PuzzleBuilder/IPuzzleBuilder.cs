using TN.Abstractions.Entities;

namespace TN.Abstractions.BLL.PuzzleBuilder
{
    public interface IPuzzleBuilder <T>
    {
        void BuilPuzzle();
        Puzzle<T> GetPuzzle();
    }
}