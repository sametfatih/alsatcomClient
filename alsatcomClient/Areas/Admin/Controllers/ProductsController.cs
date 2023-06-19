using alsatcomClient.Areas.Admin.Models;
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

        public IActionResult ProductList()
        {
            return View();
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
    }
}
