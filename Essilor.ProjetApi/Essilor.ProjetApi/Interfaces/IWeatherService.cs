using Kata.WeatherProjectApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kata.WeatherProjectApi.Interfaces
{
    public interface IWeatherService
    {
        IEnumerable<Weather> GetAllWeather();

        IEnumerable<Weather> GetWeatherByCountry(string country);
    }
}
