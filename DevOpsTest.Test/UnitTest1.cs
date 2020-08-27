using DevOpsTest.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Linq;

namespace DevOpsTest.Test
{
    public class Tests
    {
        WeatherForecastController weatherForecastController;
        ILogger<WeatherForecastController> logger;

        [SetUp]
        public void Setup()
        {
            var mocklogger = new Mock<ILogger<WeatherForecastController>>();
            logger = mocklogger.Object;
            weatherForecastController = new WeatherForecastController(logger);
        }

        [Test]
        public void Test_GetWeatherForecast_OkResult()
        {
            // Arrange


            // Act
            var result = weatherForecastController.Get();

            // Assert.IsInstanceOf<OkResult>(result);
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count());
        }
    }
}