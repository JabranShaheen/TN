﻿namespace TN.Abstractions.BLL.PuzzleBuilder
{
    public interface IPuzzleBuilderDirector
    {   
        void BuilPuzzle<PuzzleDataType>(IPuzzleBuilder<PuzzleDataType> puzzleBuilder);
    }
}