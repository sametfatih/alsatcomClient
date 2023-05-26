using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.Areas.Seller.Controllers
{
    [Area("Seller")]
    public class OrdersController : Controller
    {
        public IActionResult ActiveOrders()
        {
            return View();
        }
        public IActionResult PastOrders()
        {
            return View();
        }
        public IActionResult CanceledOrders()
        {
            return View();
        }
    }
}
