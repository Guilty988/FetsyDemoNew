using Microsoft.AspNetCore.Mvc;

namespace FetsyMvcUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
