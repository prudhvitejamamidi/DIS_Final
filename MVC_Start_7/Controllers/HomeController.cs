using Microsoft.AspNetCore.Mvc;
using PersonalFinanceTracker.Models;
using PersonalFinanceTracker.Repositories;

namespace PersonalFinanceTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserRepository _userRepository;

        public HomeController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            // Authenticate the user
            if (_userRepository.AuthenticateUser(user))
            {
                // Redirect the user to the dashboard
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                // Display an error message and return to the login page
                ModelState.AddModelError("", "Invalid username or password.");
                return View();
            }
        }
    }
}
