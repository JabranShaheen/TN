using NUnit.Framework;
using TN.BLL.PuzzleBuilder;
using NSubstitute;
using TN.Abstractions.BLL.PuzzleKeyBuilder;
using TN.Abstractions.Entities;

namespace TN.BLL.Test.PuzzleBuilder
{
    public class NumberSeriesPuzzleBuilderTests
    {
        
        IPuzzleKeyBuilderDirector puzzleKeyBuilderDirector;
        IPuzzleKeyBuilder<int, string> puzzleKeyBuilder;
        NumberSeriesPuzzleBuilder ObjectUnderTest;
        PuzzleKey<int, string> puzzleKey;
        Puzzle<int> puzzle;

        [SetUp]
        public void Setup()
        {

            puzzleKeyBuilderDirector = Substitute.For<IPuzzleKeyBuilderDirector>();
            puzzleKeyBuilder = Substitute.For<IPuzzleKeyBuilder<int, string>>();
            puzzleKey = new PuzzleKey<int, string>();
            puzzleKeyBuilder.GetPuzzleKey().Returns(puzzleKey);
            ObjectUnderTest = new NumberSeriesPuzzleBuilder(puzzleKeyBuilderDirector, puzzleKeyBuilder);

        }

        [Test]
        public void PuzzleDisplayIsCorrect()
        {

            puzzleKey.PuzzleSeed = 1;
            puzzleKey.OperationSeed = 1;
            puzzleKey.Operation = "+";
            puzzleKey.QuestionIndex = 3;
            puzzleKey.PuzzleSize = 6;
            puzzleKey.AnswerIndex = 3;
            puzzleKey.OptionsSize = 4;
            puzzleKey.OptionsRange = 10;

            ObjectUnderTest.BuilPuzzle();
            puzzle = ObjectUnderTest.GetPuzzle();

            if (!(
                    puzzle.PuzzleDisplay[0] == 1 &&
                    puzzle.PuzzleDisplay[1] == 2 &&
                    puzzle.PuzzleDisplay[2] == 3 &&
                    puzzle.PuzzleDisplay[3] == 4 &&
                    puzzle.PuzzleDisplay[4] == 5 &&
                    puzzle.PuzzleDisplay[5] == 6
                ))
            {
                Assert.Fail();
            }
        }

        [Test]
        public void CorrectAnswerIsCorrect()
        {

            puzzleKey.PuzzleSeed = 1;
            puzzleKey.OperationSeed = 1;
            puzzleKey.Operation = "+";
            puzzleKey.QuestionIndex = 3;
            puzzleKey.PuzzleSize = 6;

            ObjectUnderTest.BuilPuzzle();
            puzzle = ObjectUnderTest.GetPuzzle();

            if  (!(puzzle.CorrectAnswer == 4))
            {
                Assert.Fail();
            }
        }


        [Test]
        public void CorrectAnswerIsInOptionsListAtCorrectIndex()
        {

            puzzleKey.PuzzleSeed = 1;
            puzzleKey.OperationSeed = 1;
            puzzleKey.Operation = "+";
            puzzleKey.QuestionIndex = 3;
            puzzleKey.PuzzleSize = 6;
            puzzleKey.AnswerIndex = 3;
            puzzleKey.OptionsSize = 4;
            puzzleKey.OptionsRange = 10;

            ObjectUnderTest.BuilPuzzle();
            puzzle = ObjectUnderTest.GetPuzzle();

            if (!(puzzle.AnswerOptions[puzzleKey.AnswerIndex] == puzzle.CorrectAnswer))
            {
                Assert.Fail();
            }
        }

        [Test]
        public void OptionsListIsWithinCorrectRange()
        {
            puzzleKey.PuzzleSeed = 1;
            puzzleKey.OperationSeed = 1;
            puzzleKey.Operation = "+";
            puzzleKey.QuestionIndex = 3;
            puzzleKey.PuzzleSize = 6;
            puzzleKey.AnswerIndex = 3;
            puzzleKey.OptionsSize = 4;
            puzzleKey.OptionsRange = 10;

            ObjectUnderTest.BuilPuzzle();
            puzzle = ObjectUnderTest.GetPuzzle();

            foreach (int optionsObject in puzzle.AnswerOptions)
            {
                if (!
                    (
                        (optionsObject <= puzzle.CorrectAnswer + (int)puzzleKey.OptionsRange) ||
                        (optionsObject >= puzzle.CorrectAnswer - (int)puzzleKey.OptionsRange)
                    )
                   )
                {
                    Assert.Fail();
                }
            }
        }
    }
}