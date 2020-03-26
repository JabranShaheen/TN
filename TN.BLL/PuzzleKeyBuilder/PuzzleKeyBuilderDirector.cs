using TN.Abstractions.BLL.PuzzleKeyBuilder;

namespace TN.BLL.PuzzleKeyBuilder
{
    public class PuzzleKeyBuilderDirector : IPuzzleKeyBuilderDirector
    {        
        public void BuildPuzzleKey<SeedType, OperationType>(IPuzzleKeyBuilder<SeedType, OperationType> puzzleKeyBuilder)
        {
            puzzleKeyBuilder.BuildPuzzleKey();
        }
    }
}
