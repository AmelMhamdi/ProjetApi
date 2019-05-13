using Kata.WeatherProjectApi.Interfaces;
using Kata.WeatherProjectApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kata.WeatherProjectApi.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        public IEnumerable<Weather> GetAllWeather()
        {
            return GetDataFromJsonFile();
        }

        public IEnumerable<Weather> GetWeatherByCountry(string country)
        {
            var listWeather = GetDataFromJsonFile();
            return listWeather.Where(_ => _.Country == country);
        }

        private IEnumerable<Weather> GetDataFromJsonFile()
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
