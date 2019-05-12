using Essilor.ProjetApi.Business;
using Essilor.ProjetApi.Interfaces;
using Essilor.ProjetApi.Models;
using Essilor.ProjetApi.Repositories;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Essilor.ProjetApiTets.Business
{
    public class WeatherBusinessTest
    {
        [Test]
        public void GetAllWeather()
        {
            // arrange
            var listWeather = new List<Weather>()
            {
                new Weather()
                {
                    Id=1,
                    Tempurature=25.3,
                      City="Boston",
                      Country="US"

                }
            }.AsQueryable();

            Mock<IWeatherRepository> mockedRepository = new Mock<IWeatherRepository>() { CallBase = true };
            WeatherBusiness mockedBusiness = new WeatherBusiness(mockedRepository.Object);

            // act
            mockedRepository.Setup(c => c.GetAllWeather()).Returns(listWeather);
            var res = mockedBusiness.GetAllWeather();

            //Assert

            Assert.AreEqual(res.Count(), listWeather.Count());
            Assert.IsNotNull(res);
            Assert.AreEqual(res.First().Country, listWeather.First().Country);
            Assert.AreEqual(res.First().City, listWeather.First().City);
            Assert.AreEqual(res.First().Id, listWeather.First().Id);
            Assert.AreEqual(res.First().Tempurature, listWeather.First().Tempurature);
        }
    }
}
