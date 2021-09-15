using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return Ok("Some weird API response");
        }
    }
}