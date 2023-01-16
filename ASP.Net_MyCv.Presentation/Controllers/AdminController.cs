using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_MyCv.Presentation.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
