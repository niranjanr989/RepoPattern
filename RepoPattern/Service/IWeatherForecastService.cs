using RepoPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoPattern.Service
{
    //Interface for weatherforecast service
    public interface IWeatherForecastService
    {
        public Task<List<WeatherForecast>> GetWeatherForecasts();
    }
}
