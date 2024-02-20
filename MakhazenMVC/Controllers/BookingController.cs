using Microsoft.AspNetCore.Mvc;

namespace MakhazenMVC.PL.Controllers
{
	public class BookingController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
