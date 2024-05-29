using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.Controllers
{
    public class Blogs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
