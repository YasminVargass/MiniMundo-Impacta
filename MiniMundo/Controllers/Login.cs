using Microsoft.AspNetCore.Mvc;

namespace MiniMundo.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
