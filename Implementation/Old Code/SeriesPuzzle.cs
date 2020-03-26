//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Abstractions;

//namespace Series
//{
//    public class SeriesPuzzle : IPuzzle
//    {

//        private List<string> _answerOptions;
//        private string _correctAnswer;
//        private string _puzzleDisplay;
//        private string _puzzleCompleteString;

//        List<string> IPuzzle.AnswerOptions { get { return _answerOptions; } set { _answerOptions = value; }}
//        string IPuzzle.CorrectAnswer { get { return _correctAnswer; } set { _correctAnswer = value; }}
//        string IPuzzle.PuzzleDisplay { get { return _puzzleDisplay; } set { _puzzleDisplay = value; }}
//        string IPuzzle.PuzzleCompleteString { get { return _puzzleCompleteString; } set { _puzzleCompleteString = value; }}
       

//        public SeriesPuzzle(List<string> AnswerOptions,  string CorrectAnswer,        string PuzzleDisplay,        string PuzzleCompleteString,   string Formula)
//        {
//            _answerOptions = AnswerOptions;
//            _correctAnswer = CorrectAnswer;
//            _puzzleDisplay = PuzzleDisplay;
//            _puzzleCompleteString = PuzzleCompleteString;
//        }
//    }
//}
