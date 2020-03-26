using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TN.Tests.StandardSeries
{
    /// <summary>
    /// Summary description for TestPuzzleKeySeries
    /// </summary>
    [TestClass]
    public class TestStandardSeriesPuzzleBuilder
    {
        //public TestStandardSeriesPuzzleBuilder()
        //{

        //}
          
        //[TestMethod]
        //public void BuildPuzzle_Starting_From_1_adding_1()
        //{

        //    // Arrange
        //    var mock = new Mock<PuzzleKeyStandardSeries>();
            
        //    mock.SetupProperty(a => a.PuzzleStartingValue, 1);
        //    mock.SetupProperty(a => a.OperationValue, 1);
        //    mock.SetupProperty(a => a.Operation, "+");
        //    mock.SetupProperty(a => a.QuestionIndex, 0);
        //    mock.SetupProperty(a => a.NumberOfUnits, 6);
        //    mock.SetupProperty(a => a.NumberOfAnswerOptions, 10);
        //    mock.SetupProperty(a => a.AnswerOptionsDifferencial, 10);
            
           
        //    var mockPuzzleKeyBuilderDirector = new Mock<IPuzzleKeyBuilderDirector>();
        //    var mockPuzzleKeyBuilder = new Mock<IPuzzleKeyBuilder>();
        //    mockPuzzleKeyBuilder.Setup(a => a.GetPuzzleKey()).Returns(mock.Object);

        //    var ObjectToTest = new StandardSeriesPuzzleBuilder(mockPuzzleKeyBuilderDirector.Object, mockPuzzleKeyBuilder.Object);

        //    // Act

        //    ObjectToTest.BuildPuzzle();

        //    // Assert

        //    Assert.AreEqual("?, 2, 3, 4, 5, 6", ObjectToTest.GetPuzzle().PuzzleDisplay);
        //    Assert.AreEqual(1, System.Convert.ToInt32(ObjectToTest.GetPuzzle().CorrectAnswer));
        //    Assert.AreNotEqual(-1, ObjectToTest.GetPuzzle().AnswerOptions.IndexOf(1));

        //}

        //[TestMethod]
        //public void BuildPuzzle_Starting_From_2_multiplying_2()
        //{

        //    // Arrange
        //    var mock = new Mock<PuzzleKeyStandardSeries>();

        //    mock.SetupProperty(a => a.PuzzleStartingValue, 2);
        //    mock.SetupProperty(a => a.OperationValue, 2);
        //    mock.SetupProperty(a => a.Operation, "*");
        //    mock.SetupProperty(a => a.QuestionIndex, 0);
        //    mock.SetupProperty(a => a.NumberOfUnits, 6);
        //    mock.SetupProperty(a => a.NumberOfAnswerOptions, 10);
        //    mock.SetupProperty(a => a.AnswerOptionsDifferencial, 10);


        //    var mockPuzzleKeyBuilderDirector = new Mock<IPuzzleKeyBuilderDirector>();
        //    var mockPuzzleKeyBuilder = new Mock<IPuzzleKeyBuilder>();
        //    mockPuzzleKeyBuilder.Setup(a => a.GetPuzzleKey()).Returns(mock.Object);

        //    var ObjectToTest = new StandardSeriesPuzzleBuilder(mockPuzzleKeyBuilderDirector.Object, mockPuzzleKeyBuilder.Object);

        //    // Act

        //    ObjectToTest.BuildPuzzle();

        //    // Assert

        //    Assert.AreEqual("?, 4, 8, 16, 32, 64", ObjectToTest.GetPuzzle().PuzzleDisplay);
        //    Assert.AreEqual(2, System.Convert.ToInt32(ObjectToTest.GetPuzzle().CorrectAnswer));
        //    Assert.AreNotEqual(-1, ObjectToTest.GetPuzzle().AnswerOptions.IndexOf(1));

        //}
    }
}
