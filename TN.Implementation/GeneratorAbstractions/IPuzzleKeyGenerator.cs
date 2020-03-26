using TN.Abstractions.Entities;

namespace TN.Abstractions.Puzzle
{
    public interface IPuzzleKeyGenerator
    {
        PuzzleKey GenerateKey();
    }
}