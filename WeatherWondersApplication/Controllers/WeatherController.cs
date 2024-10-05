using Microsoft.AspNetCore.Mvc;
using WeatherWondersApplication.Services;

namespace WeatherWondersApplication.Controllers
{
    public class WeatherController : Controller
    {
        private readonly WeatherService _weatherService;

        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IActionResult> Index()
        {
            var weatherData = await _weatherService.GetWeatherAsync(42.3223, -83.1763);
            return View(weatherData);
        }


    }

}
