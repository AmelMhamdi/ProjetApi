using Essilor.ProjetApi.Interfaces;
using Essilor.ProjetApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essilor.ProjetApi.Business
{
    public class WeatherBusiness: IWeatherBusiness
    {
        private IWeatherRepository weatherRepository;

        public WeatherBusiness(IWeatherRepository weatherRepository)
        {
            this.weatherRepository = weatherRepository;

        }

        public IEnumerable<Weather> GetAllWeather()
        {
            return this.weatherRepository.GetAllWeather();
        }
    }
}
