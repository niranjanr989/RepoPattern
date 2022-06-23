using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepoPattern.Models;
using RepoPattern.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        /// <summary>
        /// private variables
        /// </summary>
        private readonly IWeatherForecastService _weatherForecastService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// Add Depndency in startup.cs for IWeatherForecstRepository
        public WeatherForecastController(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var weatherForecasts = await _weatherForecastService.GetWeatherForecasts();
            return Ok(weatherForecasts);
        }
    }
}
