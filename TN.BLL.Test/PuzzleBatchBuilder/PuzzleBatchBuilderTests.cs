using NUnit.Framework;
using TN.BLL.PuzzleBuilder;
using NSubstitute;
using TN.Abstractions.Entities;
using TN.Abstractions.BLL.PuzzleKeyBuilder;
using TN.Abstractions.BLL.PuzzleBatchBuilder;
using TN.BLL.PuzzleBatchBuilder;
using TN.Abstractions.BLL.PuzzleBuilder;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TN.BLL.Test.PuzzleBatchBuilderTest
{
    public class PuzzleBatchBuilderTests
    {

        IPuzzleBatchBuilder<int> numberPuzzleBatchBuilder;
        IPuzzleBuilderDirector puzzleBuilderDirector;
        IPuzzleBuilder<int> PuzzleBatchBuilder;
        Puzzle<int> NumberPuzzle;

        [SetUp]
        public void Setup()
        {            
            NumberPuzzle = new Puzzle<int>();
            NumberPuzzle.PuzzleType = "Number Puzzle";
            PuzzleBatchBuilder = Substitute.For<IPuzzleBuilder<int>>();
            PuzzleBatchBuilder.GetPuzzle().Returns(NumberPuzzle);
            puzzleBuilderDirector = Substitute.For<IPuzzleBuilderDirector>();
            numberPuzzleBatchBuilder = new NumberPuzzleBatchBuilder(puzzleBuilderDirector, PuzzleBatchBuilder, 10);
        }

        [Test]
        public void NumberOfPuzzlesGeneratedInABatchAreCorrect()
        {
            IEnumerable<Puzzle<int>> PuzzleList;

            numberPuzzleBatchBuilder.BuildPuzzleBatch();
            PuzzleList = numberPuzzleBatchBuilder.GetPuzzleBatch();

            if (!(PuzzleList.ToList().Count() == 10))
            {
                Assert.Fail();
            }                
        }
    }
}
