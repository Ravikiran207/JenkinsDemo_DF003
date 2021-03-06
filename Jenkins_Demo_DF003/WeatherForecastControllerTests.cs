using JenkinsDemo_DF003.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Collections;
using System.Linq;

namespace Jenkins_Demo_DF003
{
    public class WeatherForecastControllerTests
    {

        [Test]
        public void GetTestNotNull()
        {
            //Arrange
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var weatherForecast = new WeatherForecastController(logger.Object);

            //Act
            var result = weatherForecast.Get();

            //Assert
            Assert.IsNotNull(result);
            
        }
        [Test]
        public void GetTestIsEnumerable()
        {
            //Arrange
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var weatherForecast = new WeatherForecastController(logger.Object);

            //Act
            var result = weatherForecast.Get();

            //Assert
            
            Assert.IsInstanceOf<IEnumerable>(result);
            
        }

        [Test]
        public void GetTestIsTrue()
        {
            //Arrange
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var weatherForecast = new WeatherForecastController(logger.Object);

            //Act
            var result = weatherForecast.Get();

            //Assert
            
            Assert.True(result.Any());
        }
    }
}