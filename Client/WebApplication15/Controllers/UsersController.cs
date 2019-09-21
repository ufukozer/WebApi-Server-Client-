using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    public class UsersController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public UsersController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> List()
        {
            Task<IEnumerable<User>> result = null;
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "user");
            HttpClient client = _httpClientFactory.CreateClient("WebApplication14");
            HttpResponseMessage httpResponseMessage = await client.SendAsync(httpRequestMessage);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                result = httpResponseMessage.Content.ReadAsAsync<IEnumerable<User>>();
            }
            return View(result.Result);
        }
    }
}