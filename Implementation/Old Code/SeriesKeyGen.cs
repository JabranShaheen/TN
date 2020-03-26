//using System;
//using System.Collections;
//using Abstractions;

//namespace Series
//{
//    public class SeriesKeyGen : IKeyGen
//    {

//        //Format : Starting Number, Number of units, Question Index, Number of calculation layers, Layer-n seed, Layer-n operation. 
        
//        private static Random rnd = new Random();

//        private int StartingNumber;
//        private int NumberOfUnits;
//        private int NumberOfCalculationLayers;
//        private int QuestionIndex;
//        private Hashtable SeedOperationPairHashTable = new Hashtable();
//        int MinStart;
//        int MaxFinish;
        

//        public SeriesKeyGen(int NumOfUnits_, int Level_, int MinStart_, int MaxFinish_)
//        {
//            NumberOfUnits = NumOfUnits_;
//            NumberOfCalculationLayers = Level_;
//            MinStart = MinStart_;
//            MaxFinish = MaxFinish_;
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
//            for (int i = 0; i < NumberOfCalculationLayers; )
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
//                LayerSeedOperationCSV = LayerSeedOperationCSV +  "," + k.Value.ToString();
//            }

//            return StartingNumber.ToString() + "," + NumberOfUnits.ToString() + "," + QuestionIndex.ToString() + "," + NumberOfCalculationLayers.ToString() + LayerSeedOperationCSV;
//        }
//    }
//}
