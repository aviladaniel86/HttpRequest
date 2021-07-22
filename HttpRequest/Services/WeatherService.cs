using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpRequest
{
    public interface IWeatherService
    {
        Task<string> Get(string cityName);
    }
    public class WeatherService : IWeatherService
    {
        private HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> Get(string cityName)
        {
            var apiURL = $"?key=a12f972836e944a6ba2225308212107&q={cityName}&aqi=no";

            var response = await _httpClient.GetAsync(apiURL);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
