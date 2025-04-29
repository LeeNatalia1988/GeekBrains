using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Data;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherForecastHolder _weatherForecastHolder;

        public WeatherForecastController(WeatherForecastHolder weatherForecastHolder)
        {
            _weatherForecastHolder = weatherForecastHolder;
        }

        [HttpPost("add")]
        public IActionResult Add([FromQuery] string date, [FromQuery] string temperatureC)
        {
            if (DateTime.TryParse(date, out DateTime dateCorrect) && int.TryParse(temperatureC, out int temperatureCCorrect))
            {
                try
                {
                    _weatherForecastHolder.Add(dateCorrect, temperatureCCorrect);
                    return Ok(StatusCode(200));
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }
            else
            {
                return StatusCode(400, "Вы ввели неверный формат данных.");
            }
        }
            
        

        [HttpPut("update")]
        public IActionResult Update([FromQuery] string date, [FromQuery] string temperatureC)
        {
            if (DateTime.TryParse(date, out DateTime dateCorrect) && int.TryParse(temperatureC, out int temperatureCCorrect))
            {
                try
                {
                    _weatherForecastHolder.Update(dateCorrect, temperatureCCorrect);
                    return Ok(StatusCode(200));
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }
            else
            {
                return StatusCode(400, "Вы ввели неверный формат данных.");
            }
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] string date)
        {
            if (DateTime.TryParse(date, out DateTime dateCorrect))
            {
                try
                {
                    _weatherForecastHolder.Delete(dateCorrect);
                    return Ok(StatusCode(200));
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }
            else
            {
                return StatusCode(400, "Вы ввели неверный формат данных.");
            }
        }

        [HttpGet("get")]
        public IActionResult Get([FromQuery] string dateFrom, [FromQuery] string dateTo)
        {
            if (DateTime.TryParse(dateFrom, out DateTime dateFromCorrect) && DateTime.TryParse(dateTo, out DateTime dateToCorrect))
            {
                try
                {
                    List<WeatherForecast> forecasts = _weatherForecastHolder.Get(dateFromCorrect, dateToCorrect);
                    return Ok(forecasts);
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }
            else
            {
                return StatusCode(400, "Вы ввели неверный формат данных.");
            }
        }
    }
}
