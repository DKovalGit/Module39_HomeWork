using System;
using System.Collections.Generic;
using System.Text;
using MeteoStation.Models;

namespace MeteoStation.Repository
{
    public class WeatherRepository<T> : IRepository<T> where T : class
    {
        private Weather weather;
        public WeatherRepository()
        {
            weather = new Weather();
        }
        public T Get()
        {
            weather.TmpInside = GetTemp(18, 28);
            weather.TmpOutside = GetTemp(-20, 5);
            weather.Pressure = GetTemp(730, 770);
            
            return weather as T;
        }
        private int GetTemp(int minTemp, int maxTemp)
        {
            Random rnd = new Random();
            int value = rnd.Next(minTemp, maxTemp);
            return value;
        }
    }
}