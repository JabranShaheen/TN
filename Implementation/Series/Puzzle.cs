//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Abstractions;
    
//namespace Implementation.Series
//{
//    public class Puzzle : IPuzzle
//    {
//        private List<string> _answerOptions;
//        private string _correctAnswer;
//        private string _puzzleDisplay;
//        private string _puzzleCompleteString;

//        List<string> IPuzzle.AnswerOptions { get { return _answerOptions; } set { _answerOptions = value; } }
//        string IPuzzle.CorrectAnswer { get { return _correctAnswer; } set { _correctAnswer = value; } }
//        string IPuzzle.PuzzleDisplay { get { return _puzzleDisplay; } set { _puzzleDisplay = value; } }
//        string IPuzzle.PuzzleCompleteString { get { return _puzzleCompleteString; } set { _puzzleCompleteString = value; } }


//        public Puzzle(List<string> AnswerOptions, string CorrectAnswer, string PuzzleDisplay, string PuzzleCompleteString)
//        {
//            _answerOptions = AnswerOptions;
//            _correctAnswer = CorrectAnswer;
//            _puzzleDisplay = PuzzleDisplay;
//            _puzzleCompleteString = PuzzleCompleteString;
//        }
//    }
//}
