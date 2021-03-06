﻿using TN.Abstractions.Entities;

namespace TN.Abstractions.BLL.PuzzleKeyBuilder
{
    public interface IPuzzleKeyBuilder<SeedType, OperationType>
    {
        void BuildPuzzleKey();
        PuzzleKey<SeedType, OperationType> GetPuzzleKey();
    }
}