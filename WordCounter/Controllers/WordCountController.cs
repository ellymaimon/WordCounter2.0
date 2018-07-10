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
        public ActionResult GetResults(string word, string phrase)
        {
            RepeatCounter game = new RepeatCounter();
            game.SetUserWord(word);
            game.SetUserPhrase(phrase);
            game.GetOutcome();
            return View("Solution", game);
        }

        [HttpGet("/wordcounter/searched")]
        public ActionResult Searched()
        {
            Dictionary<string, string> searched = new Dictionary<string, string>();
            searched = RepeatCounter.GetSearched();
            return View(searched);
        }
    }
}
