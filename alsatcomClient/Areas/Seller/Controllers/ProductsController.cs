using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.Areas.Seller.Controllers
{
    [Area("Seller")]
    public class ProductsController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }
        public IActionResult ProductAdd()
        {
            return View();
        }
    }
}
