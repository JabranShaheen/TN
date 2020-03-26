using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TN.Logic.PuzzleKeyBuilder;

namespace TN.BLL.Test.PuzzleKeyBuilder
{
    public class StandardPuzzleKeyBuilderTest
    {

        StandardPuzzleKeyBuilder ObjectUnderTest;
        [SetUp]
        public void Setup()
        {
            ObjectUnderTest = new StandardPuzzleKeyBuilder();

        }

        [Test]
        public void OperationSeedValuesAreInRange()
        {
            ObjectUnderTest.BuildPuzzleKey();
            var puzzleKey = ObjectUnderTest.GetPuzzleKey();
            if (!(puzzleKey.OperationSeed >= -10 && puzzleKey.OperationSeed <= 10))
            {
                Assert.Fail();
            }
        }

        [Test]
        public void PuzzleSeedValuesAreInRange()
        {
            ObjectUnderTest.BuildPuzzleKey();
            var puzzleKey = ObjectUnderTest.GetPuzzleKey();
            if (!(puzzleKey.PuzzleSeed >= -10 && puzzleKey.PuzzleSeed <= 10))
            {
                Assert.Fail();
            }
        }

        [Test]
        public void OperationValuesAreInRange()
        {
            ObjectUnderTest.BuildPuzzleKey();
            var puzzleKey = ObjectUnderTest.GetPuzzleKey();

            if (!(puzzleKey.Operation == "+" || puzzleKey.Operation == "-" || puzzleKey.Operation == "*" || puzzleKey.Operation == "/"))
            {
                Assert.Fail();
            }
        }

        [Test]
        public void QuestionIndexesAreInRange()
        {
            ObjectUnderTest.BuildPuzzleKey();
            var puzzleKey = ObjectUnderTest.GetPuzzleKey();

            if (!(puzzleKey.QuestionIndex >= 0 && puzzleKey.QuestionIndex <= 3))
            {
                Assert.Fail();
            }
        }

        [Test]
        public void PuzzleSizeIsCorrect()
        {
            ObjectUnderTest.BuildPuzzleKey();
            var puzzleKey = ObjectUnderTest.GetPuzzleKey();

            if (!(puzzleKey.PuzzleSize== 6))
            {
                Assert.Fail();
            }
        }

        [Test]
        public void AnswerSizeIsCorrect()
        {
            ObjectUnderTest.BuildPuzzleKey();
            var puzzleKey = ObjectUnderTest.GetPuzzleKey();
            if (!(puzzleKey.OptionsSize == 4))
            {
                Assert.Fail();
            }
        }

        [Test]
        public void OptionsRangeIsCorrect()
        {
            ObjectUnderTest.BuildPuzzleKey();
            var puzzleKey = ObjectUnderTest.GetPuzzleKey();
            if (!((int)puzzleKey.OptionsRange == 10))
            {
                Assert.Fail();
            }
        }
    }
}