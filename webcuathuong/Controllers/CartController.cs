using Microsoft.AspNetCore.Mvc;

namespace webcuathuong.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
