using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.Areas.Seller.Controllers
{
    [Area("Seller")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
