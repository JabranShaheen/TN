namespace TN.Abstractions.BLL.PuzzleKeyBuilder
{
    public interface IPuzzleKeyBuilderDirector
    {
       void BuildPuzzleKey<SeedType, OperationType>(IPuzzleKeyBuilder<SeedType, OperationType> puzzleKeyBuilder);
    }
}