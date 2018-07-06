using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
    public class WordCountController : Controller
    {
        [HttpGet("/wordcounter")]
        public ActionResult Index() => View();

        [HttpGet("/wordcounter/solution")]
        public ActionResult Solution()
        {
            RepeatCounter game = new RepeatCounter();
            game.SetUserWord(Request.Query["word"]);
            game.SetUserPhrase(Request.Query["phrase"]);
            game.GetOutcome();
            return View(game);
        }
    }
}
