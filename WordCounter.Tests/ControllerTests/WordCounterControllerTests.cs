using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;
using System;
using System.Collections.Generic;

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
        public void Solution_ReturnsCorrectView_True()
        {
            WordCountController controller = new WordCountController();
            ActionResult solutionView = controller.Solution();
            Assert.IsInstanceOfType(solutionView, typeof(ViewResult));
        }

        [TestMethod]
        public void Searched_HasCorrectModelType_StringsDictionary()
        {
            ViewResult searchedView = new WordCountController().Searched() as ViewResult;
            var result = searchedView.ViewData.Model;
            Assert.IsInstanceOfType(result, typeof(Dictionary<string, string>));
        }

        [TestMethod]
        public void Searched_ReturnsCorrectView_True()
        {
            WordCountController controller = new WordCountController();
            ActionResult searchedView = controller.Searched();
            Assert.IsInstanceOfType(searchedView, typeof(ViewResult));
        }
    }

}