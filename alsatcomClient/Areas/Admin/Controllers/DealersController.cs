using alsatcomClient.Areas.Admin.Models;
using alsatcomClient.Core.Utilities.Reponses;
using alsatcomClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DealersController : Controller
    {
        private readonly IHttpClientService _httpClientService;

        public DealersController(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<IActionResult> DealerList()
        {
            var dealers = await _httpClientService.GetRequest<DataResponse<List<DealerListModel>>>("Dealer/GetAll");

            return View(dealers.Data);
        }
        [HttpGet]
        public async Task<IActionResult> DealerAdd()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DealerAdd(DealerAddModel model)
        {
            var response = await _httpClientService.PostRequest<DealerAddModel>(model, "Dealer/Create");
            if (!response.IsSuccessStatusCode)
            {
                return BadRequest(ModelState);
            }
            return Ok(ModelState);
        }
        public async Task<IActionResult> PassiveDealerList()
        {
            var dealers = await _httpClientService.GetRequest<DataResponse<List<DealerListModel>>>("Dealer/GetAllPassive");

            return View(dealers.Data);
        }
    }
}
