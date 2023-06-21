using alsatcomClient.Models;
using alsatcomClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace alsatcomClient.Controllers
{
    public class UserController : Controller
    {
        private readonly IHttpClientService _httpClientService;

        public UserController(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }
        [HttpGet]
        public IActionResult LoginRegister()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            HttpResponseMessage response = await _httpClientService.PostRequest<LoginModel>(model, "User/Login");
            if (!response.IsSuccessStatusCode)
            {
                return BadRequest(ModelState);
            }
            return Ok(ModelState);
        }
    }
}
