using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
    public class ScrabbleController : Controller
    {
        [HttpGet("/scrabble")]
        public ActionResult Index() => View();

        [HttpGet("/scrabble/solution")]
        public ActionResult Solution() => View();

        [HttpPost("/scrabble/solution")]
        public ActionResult GetResults()
        {
            ScrabbleCounter game = new ScrabbleCounter();
            game.SetInputtedWord(Request.Form["word"]);
            game.WordIntoLetters();
            game.LettersIntoPoints();
            return View("Solution", game);
        }
    }
}