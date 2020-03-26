using System.Collections.Generic;
using TN.Abstractions.Puzzle;

namespace TN.Implementation.Puzzle
{
    class Puzzle : IPuzzle
    {
        private object _PuzzleDisplay;
        private IList<string> _AnswerOptions;
        private object _CorrectAnswer;
        private string puzzleDisplay;
        private string answerOptions;
        private string correctAnswer;

        public object PuzzleDisplay => _PuzzleDisplay;
        public IList<object> AnswerOptions => (IList<object>)_AnswerOptions;
        public object CorrectAnswer => _CorrectAnswer;

        public Puzzle(object puzzleDisplay, IList<string> answerOptions, object correctAnswer)
        {            
            _PuzzleDisplay = puzzleDisplay;
            _AnswerOptions = answerOptions;
            _CorrectAnswer = correctAnswer;
        }

    }
}