using alsatcomClient.Core.Utilities.Reponses;
using alsatcomClient.Models;
using alsatcomClient.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace alsatcomClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientService _httpClientService;

        public HomeController(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<IActionResult> Index()
        {
            
            var customers = await _httpClientService.GetRequest<DataResponse<List<CustomerGetAll_VM>>>("Customer/GetAll");
         
            return View(customers.Data);
        }
    }
}
