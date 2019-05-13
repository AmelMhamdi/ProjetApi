using Kata.WeatherProjectApi.Interfaces;
using Kata.WeatherProjectApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kata.WeatherProjectApi.Business
{
    public class WeatherService: IWeatherService
    {
        private IWeatherRepository weatherRepository;

        public WeatherService(IWeatherRepository weatherRepository)
        {
            this.weatherRepository = weatherRepository;

        }

        public IEnumerable<Weather> GetAllWeather()
        {
            return this.weatherRepository.GetAllWeather();
        }

        public IEnumerable<Weather> GetWeatherByCountry(string country)
        {
            return this.weatherRepository.GetWeatherByCountry(country);
        }
    }
}
