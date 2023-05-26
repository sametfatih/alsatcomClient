using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.Areas.Seller.Controllers
{
    [Area("Seller")]
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EditProfile()
        {
            return View();
        }
    }
}
