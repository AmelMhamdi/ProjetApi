using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essilor.ProjetApi.Models
{
    public class Weather
    {
        public int Id { get; set; }

        public double Tempurature { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

    }
}
