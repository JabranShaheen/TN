using System.Collections.Generic;
using TN.Abstractions.Puzzle;

namespace TN.Implementation.Series
{
    public class SeriesPuzzleBuilder : IPuzzleBuilder
    {
        
        IPuzzleKeyGenerator _puzzleKeyGenerator;
        IPuzzleKey _currentPuzleKey;


        public SeriesPuzzleBuilder(IPuzzleKeyGenerator puzzleKeyGenerator)
        {
            _puzzleKeyGenerator = puzzleKeyGenerator;
            _currentPuzleKey = _puzzleKeyGenerator.GenerateNextKey();            
        }

        public IPuzzle BuildPuzzle()
        {
            string puzzleDisplay= "";
            List<string> answerOptions = new List<string>();
            string correctAnswer = "";

            Puzzle.Puzzle puzzle = new Puzzle.Puzzle(puzzleDisplay, answerOptions, correctAnswer);
            return puzzle;
        }

        public IPuzzle BuildPuzzle(object puzzleKey)
        {
            throw new System.NotImplementedException();
        }
    }
}