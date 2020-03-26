using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Abstractions;
using Implementation;
using Implementation.Series;

namespace TN.Test
{
    [TestClass]
    public class TestPuzzleStratagySeries
    {
        [TestMethod]
        public void ShouldHaveCorrectNumberOfUnits()
        {
            //Arrange 
            IPuzzleStratagy puzzleStratagy = new PuzzleStratagySeries();
            //Act 
            IPuzzle puzzle = puzzleStratagy.GeneratePuzzle(6, 4, 1, 1, 6);
            //Assert 


            Assert.AreEqual(6, puzzle.PuzzleDisplay);

        }
    }
}