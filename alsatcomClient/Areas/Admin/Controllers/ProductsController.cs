using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }
        public IActionResult ProductAdd() {
            return View();
        }
    }
}
