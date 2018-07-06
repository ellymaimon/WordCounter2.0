using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;
using System;

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
        public void Solution_HasCorrectModelType_RepeatCounterObject()
        {
            //Arrange
            WordCountController controller = new WordCountController();
            IActionResult actionResult = controller.GetResults();
            ViewResult solutionView = controller.Solution() as ViewResult;

            //Act
            var result = solutionView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(object));
        }
    }

}