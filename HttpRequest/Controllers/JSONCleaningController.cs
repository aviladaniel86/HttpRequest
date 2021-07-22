using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpRequest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JSONCleaningController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public JSONCleaningController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            var httpClient = _httpClientFactory.CreateClient("JsonCleaning");

            var response = await httpClient.GetAsync(string.Empty);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
