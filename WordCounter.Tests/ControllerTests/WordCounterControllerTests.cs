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
        public void Solution_HasCorrectModelType_GameObject()
        {
            //Arrange
            WordCountController controller = new WordCountController();
            IActionResult actionResult = controller.Solution();
            ViewResult solutionView = controller.Solution() as ViewResult;
            RepeatCounter game = new RepeatCounter();

            //Act
            var result = solutionView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(RepeatCounter));
        }
    }

}