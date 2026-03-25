using Microsoft.AspNetCore.Mvc;

namespace JenkinWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index =>
            {
                var tempC = Random.Shared.Next(-20, 55);

                return new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = tempC,
                    Summary = GetSummary(tempC) 
                };
            })
            .ToArray();
        }

        private string GetSummary(int temperatureC)
        {
            if (temperatureC < 0)
                return "Freezing";

            if (temperatureC < 10)
                return "Cold";

            if (temperatureC < 25)
                return "Normal";

            return "Hot";
        }
    }
}