using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class loggedInController : Controller
    {
        public IActionResult authorized()
        {
            return View();
        }
    }
}
