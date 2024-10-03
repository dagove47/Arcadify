using Microsoft.AspNetCore.Mvc;

namespace ArcadifyWeb.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
