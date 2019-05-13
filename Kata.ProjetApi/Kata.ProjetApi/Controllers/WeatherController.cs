using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kata.WeatherProjectApi.Interfaces;
using Kata.WeatherProjectApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kata.WeatherProjectApi.Controllers
{
    [Route("")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private IWeatherService WeatherService;

        public WeatherController(IWeatherService WeatherService)
        {
            this.WeatherService = WeatherService;
        }

        [HttpGet("GetAllWeather")]
        [ProducesResponseType(typeof(IEnumerable<Weather>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAllWeather()
        {
           try
            {
                return Ok(this.WeatherService.GetAllWeather());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("GetWeatherByCountry")]
        [ProducesResponseType(typeof(IEnumerable<Weather>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetWeatherByCountry(string country)
        {
            try
            {
                return Ok(this.WeatherService.GetWeatherByCountry(country));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}