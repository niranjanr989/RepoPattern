using RepoPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoPattern.Repository
{
    /// <summary>
    /// WeatherForecastRepository To handle all the database operations
    /// </summary>
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        //Add db dependencies to constuctor and startup and use them
        public WeatherForecastRepository()
        {
        }

        /// <summary>
        /// Gets all WeatherForecasts
        /// </summary>
        public async Task<List<WeatherForecast>> GetWeatherForecasts()
        {
            ///DB code
            ///Use await for db response
            return ExecuteReader();
        }

        #region Weather Data
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private List<WeatherForecast> ExecuteReader()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToList();
        }
        #endregion
    }
}
