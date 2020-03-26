using System;
using System.Collections.Generic;
using System.Text;
using TN.Abstractions.BLL.PuzzleBatchBuilder;
using TN.Abstractions.BLL.PuzzleBuilder;
using TN.Abstractions.BLL.PuzzleManager;
using TN.Abstractions.Entities;

namespace TN.BLL.PuzzleBatchBuilder
{
    public class NumberPuzzleBatchBuilder : IPuzzleBatchBuilder<int>
    {

        IPuzzleManager<int> _puzzleManager;
        int _batchCount;

        IEnumerable<Puzzle<int>> puzzles;

        public NumberPuzzleBatchBuilder (
                                            IPuzzleManager<int> puzzleManager,
                                            int batchCount
                                        )
        {
            _puzzleManager = puzzleManager;
            _batchCount = batchCount;
        }

        public void BuildPuzzleBatch()
        {
            List<Puzzle<int>> puzzlesList = new List<Puzzle<int>>();

            for (int i = 0; i < _batchCount; i++)
            {                
                puzzlesList.Add(_puzzleManager.ConstructPuzzle());
            }
            puzzles = puzzlesList;
        }

        public IEnumerable<Puzzle<int>> GetPuzzleBatch()
        {
            return puzzles;
        }
    }
}