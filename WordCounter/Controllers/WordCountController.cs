using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
    public class WordCountController : Controller
    {
        [HttpGet("/wordcounter")]
        public ActionResult Index() => View();

        [HttpGet("/wordcounter/solution")]
        public ActionResult Solution() => View();

        [HttpPost("/wordcounter/solution")]
        public ActionResult GetResults()
        {
            RepeatCounter game = new RepeatCounter();
            game.SetUserWord(Request.Form["word"]);
            game.SetUserPhrase(Request.Form["phrase"]);
            game.GetOutcome();
            return View("Solution", game);
        }

        [HttpPost("/wordcounter/searched")]
        public ActionResult AllWords()
        {
            RepeatCounter.GetAllPhrases();
            RepeatCounter.GetAllWords();
            return View("Searched", game);
        }

        [HttpGet("/wordcounter/searched")]
        public ActionResult Searched() => View();
    }
}
