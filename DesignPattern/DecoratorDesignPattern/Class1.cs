using Microsoft.Extensions.Caching.Memory;
using System;

namespace DecoratorDesignPattern
{
    public interface IWeatherService
    {
        string GetCurrentWeather(String location);
        string GetForecast(String location);
    }


    public class WeatherService : IWeatherService
    {
        public string GetCurrentWeather(string location)
        {
            return "24 degree";
        }

        public string GetForecast(string location)
        {
            return "partly cloudy";
        }
    }

    public class WeatherServiceCachingDecorator : IWeatherService
    {
        private readonly IMemoryCache _cache;
        private readonly IWeatherService _innerWeatehrService;
        public WeatherServiceCachingDecorator(IWeatherService weatherService, IMemoryCache cache)
        {
            _innerWeatehrService = weatherService;
            _cache = cache;
        }

        public string GetCurrentWeather(string location)
        {
            string cacheKey = $"WeatherConditions::{location}";
            if (_cache.TryGetValue<string>(cacheKey, out var currentWeather))
            {
                return currentWeather;
            }
            else
            {
                var currentConditions = _innerWeatehrService.GetCurrentWeather(location);
                _cache.Set<string>(cacheKey, currentConditions, TimeSpan.FromMinutes(30));
                return currentConditions;
            }
        }

        public string GetForecast(string location)
        {
            string cacheKey = $"WeatherForecast::{location}";
            if (_cache.TryGetValue<string>(cacheKey, out var forecast))
            {
                return forecast;
            }
            else
            {
                var locationForecast = _innerWeatehrService.GetForecast(location);
                _cache.Set<string>(cacheKey, locationForecast, TimeSpan.FromMinutes(30));
                return locationForecast;
            }
        }

    }


    public class WeatherServiceLoggingDecorator : IWeatherService
    {
        private readonly IWeatherService _innerWeatherService;
        public WeatherServiceLoggingDecorator(IWeatherService weatherService)
        {
            _innerWeatherService = weatherService;
        }

        public string GetCurrentWeather(string location)
        {
            var currentConditions = _innerWeatherService.GetCurrentWeather(location);
            Console.WriteLine("GetCurrentWeather logging");
            return currentConditions;
        }

        public string GetForecast(string location)
        {
            var locationForecast = _innerWeatherService.GetForecast(location);
            Console.WriteLine("GetForecast logging");
            return locationForecast;
        }
    }
}