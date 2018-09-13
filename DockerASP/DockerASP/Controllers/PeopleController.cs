using Microsoft.AspNetCore.Mvc;

namespace DockerASP.Controllers
{
    public class PeopleController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}