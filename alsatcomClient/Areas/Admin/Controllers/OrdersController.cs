using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.Areas.Admin.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
