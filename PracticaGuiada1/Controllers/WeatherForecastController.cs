using Microsoft.AspNetCore.Mvc;
using PracticaGuiada1.Modelos;

namespace PracticaGuiada1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost]
        public string mensaje([FromBody] Mensaje mensaje)
        {
            Mensaje algo = new messaje(messaje.Nombre, messaje.Edad);

            Persona persona = new Persona()
            {
                Edad = 18,
                Nombre = "Roberto",
                Direccion = "Calle Coapa"
            };

            return String.Format($"Hola mi nombre es {mensaje.Nombre} y mi edad es {mensaje.Edad} años");
        }
    }
}