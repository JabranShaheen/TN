using System.Collections.Generic;

namespace TN.Abstractions.Entities
{
    public class Puzzle <PuzzleDataType>
    {
        public string PuzzleType { get; set; }
        public List<PuzzleDataType> PuzzleDisplay { get; set; }
        public List<PuzzleDataType> AnswerOptions { get; set; }
        public PuzzleDataType CorrectAnswer { get; set; }
    }
}