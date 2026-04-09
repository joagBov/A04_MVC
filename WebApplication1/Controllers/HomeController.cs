using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static List<UserAccount> userAccounts = new List<UserAccount>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Guest()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View("Privacy");
        }
        [HttpPost]
        public IActionResult Register(UserAccount userAccount)
        {
            if (ModelState.IsValid)
            {
                userAccounts.Add(userAccount);
                
                HttpContext.Session.SetString("Username", userAccount.Username);
                HttpContext.Session.SetString("Email", userAccount.Email);
                HttpContext.Session.SetString("FullName", userAccount.FullName);
                HttpContext.Session.SetString("Password", userAccount.Password);
                
                return RedirectToAction("Profile", "loggedIn");
            }
            return View("Privacy", userAccount);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
