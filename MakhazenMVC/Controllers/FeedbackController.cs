using Microsoft.AspNetCore.Mvc;

namespace MakhazenMVC.PL.Controllers
{
	public class FeedbackController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
