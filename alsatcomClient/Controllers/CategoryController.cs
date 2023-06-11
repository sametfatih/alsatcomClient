using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
