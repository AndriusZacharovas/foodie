using Microsoft.AspNetCore.Mvc;

namespace foodie.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}