using Microsoft.AspNetCore.Mvc;

namespace MakhazenMVC.PL.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
