using Newtonsoft.Json;
using WeatherWondersApplication.Models;

namespace WeatherWondersApplication.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;

        private readonly string _apiKey;

        public WeatherService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiKey = configuration["OpenWeather:ApiKey"];
        }

        public async Task<WeatherResponse> GetWeatherAsync(double lat, double lon)
        {

            var url = $"https://api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&appid={_apiKey}&units=imperial";
            var response = await _httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<WeatherResponse>(response);
        }
    }
}


