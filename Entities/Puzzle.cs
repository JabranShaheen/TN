using System.Collections.Generic;

namespace TN.Abstractions.Entities
{
    public class Puzzle <T>
    {
        public List<T> PuzzleDisplay { get; set; }
        public List<T> AnswerOptions { get; set; }
        public T CorrectAnswer { get; set; }
    }
}