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
                    Temperature=25.3,
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
            Assert.AreEqual(res.First().Temperature, listWeather.First().Temperature);
        }

        [Test]
        public void GetWeatherByCountry_Ok()
        {
            // arrange
            string country = "US";

            var listWeather = new List<Weather>()
            {
                new Weather()
                {
                    Temperature=25.3,
                      City="Boston",
                      Country="US"
                },
                 new Weather()
                {
                    Temperature=22.8,
                      City="San Francisco",
                      Country="UK"
                }
            }.AsQueryable();

            Mock<IWeatherRepository> mockedRepository = new Mock<IWeatherRepository>() { CallBase = true };
            WeatherBusiness mockedBusiness = new WeatherBusiness(mockedRepository.Object);

            // act
            mockedRepository.Setup(c => c.GetWeatherByCountry(It.IsAny<string>())).Returns(listWeather);
            var res = mockedBusiness.GetWeatherByCountry(country);

            //Assert

            var resaltUS = res.Where(c => c.Country == country);
            Assert.AreEqual(resaltUS.Count(), listWeather.Where(c => c.Country == country).Count());
            Assert.IsNotNull(resaltUS);
            Assert.AreEqual(resaltUS.First().Country, listWeather.Where(c => c.Country == country).First().Country);
            Assert.AreEqual(resaltUS.First().City, listWeather.Where(c => c.Country == country).First().City);
            Assert.AreEqual(resaltUS.First().Temperature, listWeather.Where(c => c.Country == country).First().Temperature);


        }
    }
}
