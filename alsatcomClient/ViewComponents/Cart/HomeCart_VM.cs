using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.ViewComponents.Cart
{
    public class HomeCart_VM : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
