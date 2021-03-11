using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADV.REST.Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<WeatherForecast> lsWeather = new List<WeatherForecast>();

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return lsWeather;
        }

        [HttpPost]
        public void AddNewWeatherForecast([FromBody] WeatherForecast weatherCurrent)
        {
            lsWeather.Add(weatherCurrent);
        }

        [HttpDelete]
        public void DeleteAll()
        {
            lsWeather.Clear();
        }

        [HttpPut]
        public void UpdateWeatherForId(int Id, WeatherForecast weatherCurrent)
        {
            lsWeather[Id] = weatherCurrent;
        }
    }
}
