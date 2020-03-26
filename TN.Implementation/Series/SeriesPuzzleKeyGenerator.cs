using System;

namespace TN.Implementation.Series
{
    public class SeriesPuzzleKeyGenerator 
    {

        private int _PuzzleStartMin;
        private int _PuzzleStartMax;
        private int _OperationMin;
        private int _OperationMax;
        private int _NumberOfUnits;
        private String[] Operations = new string[4] { "+", "-", "*", "/" };

        public SeriesPuzzleKeyGenerator(int puzzleSeedMin ,int puzzleSeedMax, int operationSeedMin, int operationSeedMax, int numberOfUnits)
        {
            _PuzzleStartMin = puzzleSeedMin;
            _PuzzleStartMax = puzzleSeedMax;
            _OperationMin = operationSeedMin;
            _OperationMax = operationSeedMax;
            _NumberOfUnits = numberOfUnits;
        }

        SeriesPuzzleKey GenerateKey()
        {

            SeriesPuzzleKey seriesPuzzleKeyObject = new SeriesPuzzleKey();

            Random rnd = new Random();

            seriesPuzzleKeyObject.PuzzleStart = rnd.Next((int)_PuzzleStartMin, (int)_PuzzleStartMax);
            seriesPuzzleKeyObject.Operation = Operations[rnd.Next((int)_OperationMin, (int)_OperationMax)];
            seriesPuzzleKeyObject.NumberOfUnits = _NumberOfUnits;

            return seriesPuzzleKeyObject;

        }
    }
}
