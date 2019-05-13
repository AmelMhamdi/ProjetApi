using Kata.WeatherProjectApi.Controllers;
using Kata.WeatherProjectApi.Interfaces;
using Kata.WeatherProjectApi.Models;
using Kata.WeatherProjectApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.WeatherProjectApiTets.Controllers
{
    public class WeatherControllerTest
    {
        [Test]
        public void GetAllWeather_Return_OK()
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


            Mock<IWeatherRepository> mockedrepository = new Mock<IWeatherRepository>();
            Mock<IWeatherService> mockedBusiness = new Mock<IWeatherService>() { CallBase = true };
            mockedrepository.Setup(c => c.GetAllWeather()).Returns(listWeather);
            mockedBusiness.Setup(c => c.GetAllWeather()).Returns(listWeather);
            WeatherController controller = new WeatherController(mockedBusiness.Object);
            var result = controller.GetAllWeather();
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.That(okResult.Value == listWeather);
            Assert.That(StatusCodes.Status200OK == okResult.StatusCode);
        }

    }
}
