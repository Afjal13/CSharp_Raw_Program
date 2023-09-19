using Microsoft.AspNetCore.Mvc;

namespace PythonASP.Controllers
{
    public class PythonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
