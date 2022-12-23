using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ResilienceMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        [HttpGet("")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet("home/throw")]
        public ActionResult Throwing()
        {
             throw new Exception("You have have hit an exception, go back to Västerås");
        }

        [HttpGet("error/exception")]
        public IActionResult ServerError()
        {
            return View();
        }


    }
}
