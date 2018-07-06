using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
    public class WordCountController : Controller
    {
        [HttpGet("/wordcounter")]
        public ActionResult Index() => View();

        // [HttpGet("/wordcounter/solution")]
        // public ActionResult Solution()
        // {
        //     return View();
        // }
    }
}
