using System.Collections.Generic;
using System.Threading.Tasks;
using RepoPattern.Models;
using RepoPattern.Repository;

namespace RepoPattern.Service
{
    /// <summary>
    /// WeatherForecastService to handle all the business logics
    /// </summary>
    public class WeatherForecastService : IWeatherForecastService
    {
        ///Private members
        private readonly IWeatherForecastRepository _weatherForecastRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// Add Depndency in startup.cs for IWeatherForecstRepository
        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastRepository = weatherForecastRepository;
        }

        /// <summary>
        /// Gets all WeatherForecasts
        /// </summary>
        /// We might not need async await here but this is just to showcase on how to use it
        /// Note: use await only when needed syncronus programming
        public async Task<List<WeatherForecast>> GetWeatherForecasts()
        {
            return await _weatherForecastRepository.GetWeatherForecasts();

            //usecase of await
            //var hydWeather = await GetWeatherByCity("Hyd");
            //if(hydWeather.temp < 40)
            //{
            // Do something;
            // Here we have dependency with hydWeather which is retrived only after GetWeatherByCity is executed
            // A case where await is needed
            //}
        }
    }
}