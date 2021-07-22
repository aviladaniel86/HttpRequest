using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HttpRequest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherForecastController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public async Task<string> Get(string cityName)
        {
            return await _weatherService.Get(cityName);
        }
    }
}
