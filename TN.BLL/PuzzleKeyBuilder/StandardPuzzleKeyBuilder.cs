using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN.Abstractions.Entities;
using TN.Abstractions.BLL.PuzzleKeyBuilder;

namespace TN.Logic.PuzzleKeyBuilder
{
    public class StandardPuzzleKeyBuilder : IPuzzleKeyBuilder<int, string>
    {
        PuzzleKey<int, string> puzzleKey;
        List<string> listOfOperations = new List<string>(){"+","-","*","/"};
        int selectedOperationsIndex = -1;

        public StandardPuzzleKeyBuilder()
        {
            puzzleKey = new PuzzleKey<int, string>();
            puzzleKey.PuzzleSeed = -100;
            puzzleKey.OperationSeed = -100;
            puzzleKey.QuestionIndex = -1;
        }

        public void BuildPuzzleKey()
        {

            puzzleKey.PuzzleSeed = new Random().Next(-10, 10);
            puzzleKey.OperationSeed = new Random().Next(-10, 10);

            selectedOperationsIndex = new Random().Next(1, 4);
            puzzleKey.Operation = listOfOperations.ElementAt(selectedOperationsIndex);
            puzzleKey.QuestionIndex = new Random().Next(0, 3);
            puzzleKey.PuzzleSize = 6;
            puzzleKey.OptionsSize = 4;
            puzzleKey.OptionsRange = 10;
        }

        public PuzzleKey<int, string> GetPuzzleKey()
        {            
            return puzzleKey;
        }
    }
}
