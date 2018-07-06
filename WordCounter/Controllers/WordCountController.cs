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
            return View();
        }

        [HttpPost("/wordcounter/solution")]
        public ActionResult GetResults()
        {
            RepeatCounter game = new RepeatCounter();
            game.SetUserWord(Request.Form["word"]);
            game.SetUserPhrase(Request.Form["phrase"]);
            game.GetOutcome();
            return View("Solution", game);
        }
    }
}
