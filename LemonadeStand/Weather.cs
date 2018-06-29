using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public int temperatureToday;
        
        public bool chanceOfRain;

        RandomNumber RNG = new RandomNumber();

        public Weather()
        {
            

        }

        public void WeatherToday()
        {
            temperatureToday = GetTemperatureToday();
            chanceOfRain = GetRainCondition();
        }   

        public void DisplayWeather()
        {
            Console.WriteLine($"The temperature today is {temperatureToday}");
        }

        public int GetTemperatureToday()
        {

            int minTemp = 55;
            int maxTemp = 100;
            temperatureToday = RNG.RandomNumberGenerator(minTemp, maxTemp);
            return temperatureToday;
        }

        public bool GetRainCondition()
        {

            int min = 0;
            int max = 100;
            int result = RNG.RandomNumberGenerator(min, max);
            if(result >= 80)
            {
            return true;
            }
            else
            {
            return false;
            }
        }

        
        


    }
}

