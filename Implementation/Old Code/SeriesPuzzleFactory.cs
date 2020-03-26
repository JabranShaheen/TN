//using Abstractions;
//using Unity;
//using System.Collections.Generic;
//using System;

//namespace Series
//{
//    public class SeriesPuzzleFactory : IPuzzleFactory
//    {
//        private IPuzzle _puzzle;

//        private int _numOfUnits;
//        private int _level;
//        private int _minStart;
//        private int _maxFinish;        

//        public SeriesPuzzleFactory(int NumOfUnits, int Level, int MinStart, int MaxFinish, IUnityContainer UnityContainer)
//        {
//            _numOfUnits = NumOfUnits;
//            _level = Level;
//            _minStart = MinStart;
//            _maxFinish = MaxFinish;
//            _keyGen = UnityContainer.Resolve<IKeyGen>("Series");
//        }


//        private void PopulateStartingNumber()
//        {
//            StartingNumber = rnd.Next(MinStart, MaxFinish);
//        }

//        private void PopulateSeedOperationPair()
//        {

//            string SeedOperationPair = "";
//            int SeedValue;
//            int OperationValue;
//            SeedOperationPairHashTable.Clear();
//            for (int i = 0; i < NumberOfCalculationLayers;)
//            {
//                SeedValue = rnd.Next(MinStart, MaxFinish);
//                OperationValue = rnd.Next(1, 4);

//                SeedOperationPair = SeedValue.ToString() + "," + OperationValue.ToString();
//                SeedOperationPairHashTable.Add(i, SeedOperationPair);
//                i++;
//            }
//        }

//        private void PopulateQuestionIndex()
//        {
//            QuestionIndex = rnd.Next(0, NumberOfUnits);
//        }

//        public string GetNewKey()
//        {

//            PopulateStartingNumber();
//            PopulateQuestionIndex();
//            PopulateSeedOperationPair();

//            string LayerSeedOperationCSV = "";

//            foreach (DictionaryEntry k in SeedOperationPairHashTable)
//            {
//                LayerSeedOperationCSV = LayerSeedOperationCSV + "," + k.Value.ToString();
//            }

//            return StartingNumber.ToString() + "," + NumberOfUnits.ToString() + "," + QuestionIndex.ToString() + "," + NumberOfCalculationLayers.ToString() + LayerSeedOperationCSV;
//        }
    

//    public IPuzzle GeneratePuzzle()
//        {

//            PreparePuzzle();
//            PrepareAnswerOptions();

//            return _puzzle;
//        }

//        private void PreparePuzzle()
//        {
//            string StrKey = _keyGen.GetNewKey();
//            string[] CSVvalues = StrKey.Split(',');

//            int StartingNumber = int.Parse(CSVvalues[0]);
//            int NumberOfUnits = int.Parse(CSVvalues[1]);
//            int QuestionIndex = int.Parse(CSVvalues[2]);
//            int NumberOfCalculationLayers = int.Parse(CSVvalues[3]);

//            int PreviousAddedNumber = 0;
//            int CurrentNumber = 0;
//            int CurrentOperation = 0;
//            int CurrentSeed = 0;

//            List<int> LayerNSeeds = new List<int>();
//            List<int> LayerNOperation = new List<int>();
//            List<int> GeneratedSeries = new List<int>();

//            for (int i = 4; i < CSVvalues.Length;)
//            {
//                LayerNSeeds.Add(int.Parse(CSVvalues[i]));
//                i++;
//                LayerNOperation.Add(int.Parse(CSVvalues[i]));
//                i++;
//            }

//            GeneratedSeries.Add(StartingNumber);
//            PreviousAddedNumber = StartingNumber;

//            for (int i = 1; i < NumberOfUnits; i++)
//            {
//                for (int j = 0; j < NumberOfCalculationLayers; j++)
//                {

//                    CurrentOperation = LayerNOperation[j];
//                    CurrentSeed = LayerNSeeds[j];

//                    if (CurrentOperation == 1)
//                    {
//                        CurrentNumber = PreviousAddedNumber + CurrentSeed;
//                    }
//                    else if (CurrentOperation == 2)
//                    {
//                        CurrentNumber = PreviousAddedNumber - CurrentSeed;
//                    }
//                    else if (CurrentOperation == 3)
//                    {
//                        CurrentNumber = PreviousAddedNumber * CurrentSeed;
//                    }
//                    else if (CurrentOperation == 4)
//                    {
//                        CurrentNumber = PreviousAddedNumber / CurrentSeed;
//                    }

//                    PreviousAddedNumber = CurrentNumber;
//                }
//                GeneratedSeries.Add(CurrentNumber);
//            }

//            for (int i = 0; i < GeneratedSeries.Count; i++)
//            {
//                _puzzle.PuzzleCompleteString = _puzzle.PuzzleCompleteString + GeneratedSeries[i].ToString() + ", ";
//                if (i == QuestionIndex)
//                {
//                    _puzzle.PuzzleDisplay = _puzzle.PuzzleDisplay + "?";
//                    _puzzle.CorrectAnswer = GeneratedSeries[i].ToString();
//                }
//                else
//                {
//                    _puzzle.PuzzleDisplay = _puzzle.PuzzleDisplay + GeneratedSeries[i].ToString();
//                }
//                if (i + 1 < GeneratedSeries.Count)
//                {
//                    _puzzle.PuzzleDisplay = _puzzle.PuzzleDisplay + ", ";
//                }
//            }
//        }

//        private void PrepareAnswerOptions()
//        {
//            try
//            {
//                int CurrentAnswer = 0;
//                int CurrentAnswerSeed;
//                int CurrentAnswerOperation;
//                int CorrectAnswerIndex;

//                for (int i = 0; i < 4;)
//                {
//                    Random rnd = new Random();
//                    CurrentAnswerSeed = rnd.Next(1, 5);
//                    CurrentAnswerOperation = rnd.Next(1, 4);

//                    if (CurrentAnswerOperation == 1)
//                    {
//                        CurrentAnswer = int.Parse(_puzzle.CorrectAnswer) + CurrentAnswerSeed;
//                    }
//                    else if (CurrentAnswerOperation == 2)
//                    {
//                        CurrentAnswer = int.Parse(_puzzle.CorrectAnswer) - CurrentAnswerSeed;
//                    }
//                    else if (CurrentAnswerOperation == 3)
//                    {
//                        CurrentAnswer = int.Parse(_puzzle.CorrectAnswer) * CurrentAnswerSeed;
//                    }
//                    else if (CurrentAnswerOperation == 4)
//                    {
//                        CurrentAnswer = int.Parse(_puzzle.CorrectAnswer) / CurrentAnswerSeed;
//                    }

//                    if (!_puzzle.AnswerOptions.Contains(CurrentAnswer.ToString()) & CurrentAnswer.ToString() != _puzzle.CorrectAnswer)
//                    {
//                        _puzzle.AnswerOptions[i] = CurrentAnswer.ToString();
//                        i++;
//                    }
//                }
//                Random rnd2 = new Random();
//                CorrectAnswerIndex = rnd2.Next(0, 4);
//                _puzzle.AnswerOptions[CorrectAnswerIndex] = _puzzle.CorrectAnswer;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public override string ToString()
//        {
//            string retval = "";
//            retval = this._puzzle.PuzzleCompleteString;
//            return retval;
//        }

//    }
//}