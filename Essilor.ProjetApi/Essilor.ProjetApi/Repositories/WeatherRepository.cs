using Essilor.ProjetApi.Interfaces;
using Essilor.ProjetApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essilor.ProjetApi.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        public IEnumerable<Weather> GetAllWeather()
        {
            throw new NotImplementedException();
        }
    }
}
