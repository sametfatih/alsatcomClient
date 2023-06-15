using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.Controllers
{
    public class WishController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
