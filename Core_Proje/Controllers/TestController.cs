using Microsoft.AspNetCore.Mvc;

namespace Core_Proje_Enes.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
