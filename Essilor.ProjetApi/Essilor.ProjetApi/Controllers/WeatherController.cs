using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Essilor.ProjetApi.Interfaces;
using Essilor.ProjetApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Essilor.ProjetApi.Controllers
{
    [Route("")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private IWeatherBusiness weatherBusiness;

        public WeatherController(IWeatherBusiness weatherBusiness)
        {
            this.weatherBusiness = weatherBusiness;
        }

        [HttpGet("GetAllWeather")]
        [ProducesResponseType(typeof(Weather), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAllWeather()
        {
           try
            {
                return Ok(this.weatherBusiness.GetAllWeather());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}