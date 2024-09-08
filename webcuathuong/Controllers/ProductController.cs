using Microsoft.AspNetCore.Mvc;

namespace webcuathuong.Controllers
{
    public class ProductController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

    }
}
