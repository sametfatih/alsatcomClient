using alsatcomClient.Areas.Admin.Models;
using alsatcomClient.Core.Utilities.Reponses;
using alsatcomClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.Areas.Admin.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IHttpClientService _httpClientService;

        public OrdersController(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        
    }
}
