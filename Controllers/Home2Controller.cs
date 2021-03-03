using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    [Route("[controller]/[action]")]
    public class Home2Controller : Controller
    {
        [Route("~/")]
        [Route("/Home2")]
        [Route("~/Home2/Index")]
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult About()
        {
            return View();
        }
    }
}