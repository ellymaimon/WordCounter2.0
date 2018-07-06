using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            WordCountController controller = new WordCountController();
            ActionResult indexView = controller.Index();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Solution_HasCorrectModelType_Object()
        {
            //Arrange
            WordCountController controller = new WordCountController();
            IActionResult actionResult = controller.Solution();
            ViewResult solutionView = controller.Solution() as ViewResult;
            RepeatCounter game = new RepeatCounter();

            //Act
            var result = solutionView.ViewData.Model;
            var r2 = result.GetType();
            var r3 = game.GetType();
            Console.WriteLine(r2);
            Console.WriteLine(r3);

            //Assert
            Assert.AreEqual(r2, r3);
        }
    }

}