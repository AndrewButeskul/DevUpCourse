using DevUp.Core;
using DevUp.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevUp.Web.Controllers
{
    [Route("api/user")]
    public class UserController : Controller
    {
        private readonly AppDBContext _context;
        public UserController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var list = _context.Users.ToList();

            return Ok(list);
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            //var user = new User() { Email = "test@devup.com", Password = "user"};

            _context.Add(user);

            _context.SaveChanges();

            return Created("",user);

        }
    }
}
