using Kata.WeatherProjectApi.Business;
using Kata.WeatherProjectApi.Interfaces;
using Kata.WeatherProjectApi.Models;
using Kata.WeatherProjectApi.Repositories;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.WeatherProjectApiTets.Business
{
    public class WeatherServiceTest
    {
        [Test]
        public void When_List_Weather_Not_Empty_GetAllWeather()
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
            WeatherService mockedBusiness = new WeatherService(mockedRepository.Object);
            mockedRepository.Setup(c => c.GetAllWeather()).Returns(listWeather);

            // act
            var res = mockedBusiness.GetAllWeather();

            //Assert
            Assert.That(res.Count() == listWeather.Count());
            Assert.IsNotNull(res);
            Assert.That(res.First().Country == listWeather.First().Country);
            Assert.That(res.First().City == listWeather.First().City);
            Assert.That(res.First().Temperature == listWeather.First().Temperature);
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
            WeatherService mockedBusiness = new WeatherService(mockedRepository.Object);

            // act
            mockedRepository.Setup(c => c.GetWeatherByCountry(It.IsAny<string>())).Returns(listWeather);
            var res = mockedBusiness.GetWeatherByCountry(country);

            //Assert

            var resaltUS = res.Where(c => c.Country == country);
            Assert.That(resaltUS.Count() == listWeather.Where(c => c.Country == country).Count());
            Assert.IsNotNull(resaltUS);
            Assert.That(resaltUS.First().Country == listWeather.Where(c => c.Country == country).First().Country);
            Assert.That(resaltUS.First().City == listWeather.Where(c => c.Country == country).First().City);
            Assert.That(resaltUS.First().Temperature == listWeather.Where(c => c.Country == country).First().Temperature);


        }
    }
}
