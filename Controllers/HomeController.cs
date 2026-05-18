using Microsoft.AspNetCore.Mvc;

namespace StudentClubManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clubs()
        {
            return View();
        }

        public IActionResult Students()
        {
            return View();
        }

        public IActionResult Activities()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}