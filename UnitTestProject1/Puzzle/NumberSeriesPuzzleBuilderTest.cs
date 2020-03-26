using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TN.Abstractions.Puzzle;
using TN.Implementation.Series;

namespace TN.Tests
{
    [TestClass]
    public class NumberSeriesPuzzleBuilderTest
    {
        [TestMethod]
        public void PuzzleDisplayForAddOperation()
        {
            //Arrange
            Mock<IPuzzleKeyGenerator> PuzzleKeyGeneratorMock = new Mock<IPuzzleKeyGenerator>();
            Mock<IPuzzleKey> PuzzleKeyMock = new Mock<IPuzzleKey>();            
            PuzzleKeyMock.Setup(_PuzzleKeyMock => _PuzzleKeyMock.Operation).Returns(1);
            PuzzleKeyMock.Setup(_PuzzleKeyMock => _PuzzleKeyMock.NumberOfUnits).Returns(6);            
            PuzzleKeyMock.Setup(_PuzzleKeyMock => _PuzzleKeyMock.OperationSeed).Returns(2);
            PuzzleKeyMock.Setup(_PuzzleKeyMock => _PuzzleKeyMock.Operation).Returns(2);
            PuzzleKeyMock.Setup(_PuzzleKeyMock => _PuzzleKeyMock.PuzzleSeed).Returns(2);
            PuzzleKeyMock.Setup(_PuzzleKeyMock => _PuzzleKeyMock.PuzzleIndex).Returns(2);

            PuzzleKeyGeneratorMock.Setup(foo => foo.GenerateNextKey()).Returns(PuzzleKeyMock.Object);

            SeriesPuzzleBuilder numberSeriesPuzzleBuilder = new SeriesPuzzleBuilder(PuzzleKeyGeneratorMock.Object);
         
            //Act            
            // 2,4,6,8,10,12
            IPuzzle puzzleObject = numberSeriesPuzzleBuilder.BuildPuzzle();

            //Assert
            Assert.AreEqual("2,?,6,8,10,12", puzzleObject.PuzzleDisplay);
        }
    }
}