using Microsoft.AspNetCore.Mvc;

namespace ChatForum.Controllers
{
    public class AnswerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
