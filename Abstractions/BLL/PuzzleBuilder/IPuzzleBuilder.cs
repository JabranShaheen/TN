using TN.Abstractions.Entities;

namespace TN.Abstractions.BLL.PuzzleBuilder
{
    public interface IPuzzleBuilder<PuzzleDataType>
    {
        void BuilPuzzle();
        Puzzle<PuzzleDataType> GetPuzzle() ;
    }
}