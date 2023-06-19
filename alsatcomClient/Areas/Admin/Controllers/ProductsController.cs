using alsatcomClient.Areas.Admin.Models;
using alsatcomClient.Core.Utilities.Reponses;
using alsatcomClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.Areas.Admin.Controllers
{
    [Area("Admin")]
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
        [HttpGet]
        public IActionResult ProductAdd() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ProductAdd(ProductAddModel model) {

            bool response = await  _httpClientService.PostRequest<ProductAddModel>(model,"Product/Create");
            if (!response) {
               return BadRequest(ModelState);
            }
            return Ok(ModelState);
        }
        public async Task<IActionResult> PassiveProductList()
        {

            var products = await _httpClientService.GetRequest<DataResponse<List<ProductListModel>>>("Product/GetAll");
            return View(products.Data);
        }
    }
}
