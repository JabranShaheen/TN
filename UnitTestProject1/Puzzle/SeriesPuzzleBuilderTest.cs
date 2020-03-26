using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TN.Implementation.Series;
using TN.Abstractions.Puzzle;
namespace Puzzle
{
    [TestClass]
    public class SeriesPuzzleKeyGeneratorTest
    {
        [TestMethod]
        public void PuzzleSeedBetweenFloorAndCeiling()
        {
            //Arrange
            IPuzzleKeyGenerator puzzleKeyGenerator = new SeriesPuzzleKeyGenerator(4, 1, 10, 1, 6, 4);
            IPuzzleKey PuzzleKey = new SeriesPuzzleKey();

            //Act
            PuzzleKey = puzzleKeyGenerator.GenerateNextKey();
            bool IsBetweenRange = false;
            if ((int)PuzzleKey.PuzzleSeed >= 1 && (int)PuzzleKey.PuzzleSeed <= 20)
            {
                IsBetweenRange = true;
            }

            //Assert
            Assert.AreEqual(IsBetweenRange, true);
        }     

        [TestMethod]
        public void OperationSeedBetween1And6()
        {
            //Arrange
            IPuzzleKeyGenerator puzzleKeyGenerator = new SeriesPuzzleKeyGenerator(4, 1, 10, 1, 6, 4);
            IPuzzleKey PuzzleKey = new SeriesPuzzleKey();

            //Act
            PuzzleKey = puzzleKeyGenerator.GenerateNextKey();
            bool IsBetweenRange = false;
            if ((int)PuzzleKey.OperationSeed >= 1 && (int)PuzzleKey.OperationSeed <= 6)
            {
                IsBetweenRange = true;
            }

            //Assert
            Assert.AreEqual(IsBetweenRange, true);
        }

        [TestMethod]
        public void OperationBetween1And4()
        {
            //Arrange
            IPuzzleKeyGenerator puzzleKeyGenerator = new SeriesPuzzleKeyGenerator(4, 1, 10, 1, 6, 4);
            IPuzzleKey PuzzleKey = new SeriesPuzzleKey();

            //Act
            PuzzleKey = puzzleKeyGenerator.GenerateNextKey();
            bool IsBetweenRange = false;
            if ((int)PuzzleKey.Operation >= 1 && (int)PuzzleKey.Operation <= 4)
            {
                IsBetweenRange = true;
            }

            //Assert
            Assert.AreEqual(IsBetweenRange, true);
        }

        [TestMethod]
        public void QuestionIndexBetween1And4()
        {
            //Arrange
            IPuzzleKeyGenerator puzzleKeyGenerator = new SeriesPuzzleKeyGenerator(4, 1, 10, 1, 6, 4);
            IPuzzleKey PuzzleKey = new SeriesPuzzleKey();

            //Act
            PuzzleKey = puzzleKeyGenerator.GenerateNextKey();
            bool IsBetweenRange = false;
            if ((int)PuzzleKey.PuzzleIndex >= 1 && (int)PuzzleKey.PuzzleIndex <= 4)
            {
                IsBetweenRange = true;
            }
            //Assert
            Assert.AreEqual(IsBetweenRange, true);
        }
    }
}