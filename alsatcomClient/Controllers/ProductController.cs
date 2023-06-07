using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductPage()
        {
            return View();
        }
    }
}
