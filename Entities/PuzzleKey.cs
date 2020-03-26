namespace TN.BLL.Entities
{
    public class PuzzleKey <SeedType, OperationType>
    {
        SeedType PuzzleSeed { get; set; }
        OperationType OperationSeed { get; set; }
        OperationType Operation { get; set; }
        int QuestionIndex { get; set; }
    }
}
