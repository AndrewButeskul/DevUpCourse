using Microsoft.AspNetCore.Mvc;

namespace DevUp.Web.Controllers
{
    [Route("/api/home")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var result = new { id = 1 };
            return Ok(result);
        }

    }
}
 