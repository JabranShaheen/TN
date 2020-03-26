using TN.Abstractions.BLL.PuzzleBuilder;
using TN.Abstractions.Entities;
using TN.Abstractions.BLL.PuzzleKeyBuilder;
using System.Collections.Generic;
using System;

namespace TN.BLL.PuzzleBuilder
{
    public class NumberSeriesPuzzleBuilder : IPuzzleBuilder<int>
    {
        IPuzzleKeyBuilderDirector _puzzleKeyBuilderDirector;
        IPuzzleKeyBuilder<int, string> _puzzleKeyBuilder;
        Puzzle<int> _puzzle;
        public NumberSeriesPuzzleBuilder    (
                                                IPuzzleKeyBuilderDirector puzzleKeyBuilderDirector, 
                                                IPuzzleKeyBuilder<int, string> puzzleKeyBuilder
                                            )
        {
            _puzzleKeyBuilderDirector = puzzleKeyBuilderDirector;
            _puzzleKeyBuilder = puzzleKeyBuilder;
        }
        public void BuilPuzzle()
        {
            PuzzleKey<int, string> puzzleKey;
            int currentNumberToAdd;

            _puzzleKeyBuilderDirector.BuildPuzzleKey(_puzzleKeyBuilder);
            puzzleKey = _puzzleKeyBuilder.GetPuzzleKey();

            _puzzle = new Puzzle<int>();
            _puzzle.PuzzleType = "Number Series Puzzle";

            _puzzle.PuzzleDisplay = new List<int>();
            _puzzle.AnswerOptions = new List<int>();

            currentNumberToAdd = puzzleKey.PuzzleSeed;

            for (int counter = 0; counter < puzzleKey.PuzzleSize; counter++)
            {
                _puzzle.PuzzleDisplay.Add(currentNumberToAdd);
                switch (puzzleKey.Operation)
                {
                    case "+":
                        currentNumberToAdd = currentNumberToAdd + puzzleKey.OperationSeed;
                        break;
                    case "-":
                        currentNumberToAdd = currentNumberToAdd - puzzleKey.OperationSeed;
                        break;
                    case "*":
                        currentNumberToAdd = currentNumberToAdd * puzzleKey.OperationSeed;
                        break;
                    case "/":
                        if (puzzleKey.OperationSeed == 0)
                            currentNumberToAdd = 0;
                        else
                            currentNumberToAdd = currentNumberToAdd / puzzleKey.OperationSeed;
                        break;
                }
            }

            _puzzle.CorrectAnswer = _puzzle.PuzzleDisplay[puzzleKey.QuestionIndex];

            for (int counter = 0; counter < puzzleKey.OptionsSize; counter++)
            {
                if (counter == puzzleKey.AnswerIndex)
                {
                    _puzzle.AnswerOptions.Add(_puzzle.CorrectAnswer);
                }
                else
                {
                    _puzzle.AnswerOptions.Add(
                                                new Random().Next (
                                                            _puzzle.CorrectAnswer - (int)puzzleKey.OptionsRange,
                                                            _puzzle.CorrectAnswer + (int)puzzleKey.OptionsRange
                                                                  )
                                             );
                }
            }
        }

        public Puzzle<int> GetPuzzle()
        {
            return _puzzle;
        }
    }
}
