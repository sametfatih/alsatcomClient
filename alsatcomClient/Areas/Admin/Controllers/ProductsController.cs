using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
