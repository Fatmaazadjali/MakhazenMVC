using Microsoft.AspNetCore.Mvc;

namespace MakhazenMVC.PL.Controllers
{
	public class BookingController : Controller
	{
		public IActionResult Booking()
		{
			return View();
		}
	}
}
