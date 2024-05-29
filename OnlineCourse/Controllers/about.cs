using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.Controllers
{
    public class about : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
