using alsatcomClient.Areas.Seller.Models;
using alsatcomClient.Core.Utilities.Reponses;
using alsatcomClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.Areas.Seller.Controllers
{
    [Area("Seller")]
    public class ProductsController : Controller
    {
        private readonly IHttpClientService _httpClientService;

        public ProductsController(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<IActionResult> ProductList()
        {
            var products = await _httpClientService.GetRequest<DataResponse<List<ProductListModel>>>("Product/GetAll");
            return View(products.Data);
        }
        public IActionResult ProductAdd()
        {
            return View();
        }
    }
}
