using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class loggedInController : Controller
    {
        public IActionResult authorized()
        {
            return View();
        }
        public IActionResult Profile()
        {
            ViewData["Username"] = HttpContext.Session.GetString("Username") ?? "N/A";
            ViewData["Email"] = HttpContext.Session.GetString("Email") ?? "N/A";
            ViewData["FullName"] = HttpContext.Session.GetString("FullName") ?? "N/A";
            ViewData["Password"] = HttpContext.Session.GetString("Password") ?? "N/A";
            
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            
            return RedirectToAction("Guest", "Home");
        }
    }
}
