using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_MyCv.Presentation.Controllers
{
	public class SiteController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
