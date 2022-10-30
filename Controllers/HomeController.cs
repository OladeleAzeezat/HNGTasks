using FirstAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        List<Home> home = new List<Home>();
        public HomeController()
        {
            home.Add(new Home { SlackUsername = "Azeezat", Backend = true, Age = 25, Bio = "An aspiring software engineer" });
        }

        [HttpGet]
        public  IEnumerable<Home> Get()
        {
            return home;
        }
    }
}
