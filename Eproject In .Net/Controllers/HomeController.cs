using System.Diagnostics;
using Eproject_In_.Net.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eproject_In_.Net.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult About()
		{
			return View();
		}
		public IActionResult Contact()
		{
			return View();
		}
		public IActionResult Registered()
		{
			return View();
		}

		public IActionResult Login()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
