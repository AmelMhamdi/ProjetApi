using Essilor.ProjetApi.Interfaces;
using Essilor.ProjetApi.Models;
using Newtonsoft.Json;
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
            var path = "wwwroot/Data/base.json";
            var result = new List<Weather>();

            if (System.IO.File.Exists(path))
            {
                var initialJson = System.IO.File.ReadAllText(path);
                var convertedJson = JsonConvert.DeserializeObject<List<Weather>>(initialJson);
                result.AddRange(convertedJson);
            }

            return result;
        }
    }
}
