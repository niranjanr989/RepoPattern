using RepoPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoPattern.Repository
{
    /// <summary>
    /// IWeatherForecastRepository to handle repository interfaces(to make losely coupled code)
    /// </summary>
    public interface IWeatherForecastRepository
    {
        public Task<List<WeatherForecast>> GetWeatherForecasts();
    }
}
