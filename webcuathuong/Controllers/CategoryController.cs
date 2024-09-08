using Microsoft.AspNetCore.Mvc;

namespace webcuathuong.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
