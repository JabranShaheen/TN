namespace TN.Abstractions.Entities
{
    public class PuzzleKey <SeedType, OperationType>
    {
        public SeedType PuzzleSeed { get; set; }
        public SeedType OperationSeed { get; set; }
        public OperationType Operation { get; set; }
        public int QuestionIndex { get; set; }
        public int AnswerIndex { get; set; }
        public int PuzzleSize { get; set; }
        public int OptionsSize { get; set; }
        public object OptionsRange { get; set; }
    }
}