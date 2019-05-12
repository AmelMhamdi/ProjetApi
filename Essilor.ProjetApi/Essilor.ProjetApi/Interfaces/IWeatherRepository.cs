using Essilor.ProjetApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essilor.ProjetApi.Interfaces
{
    public interface IWeatherRepository
    {
        IEnumerable<Weather> GetAllWeather();
    }
}
