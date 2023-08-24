using Microsoft.AspNetCore.Mvc;

namespace ChatForum.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
