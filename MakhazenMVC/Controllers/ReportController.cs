﻿using Microsoft.AspNetCore.Mvc;

namespace MakhazenMVC.PL.Controllers
{
	public class ReportController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
