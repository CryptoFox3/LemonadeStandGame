using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        int temperature;
        int windSpeed;
        int rain;





        public static int GetTemperatureToday()
        {

            Random randomTemp = new Random();
            int result = randomTemp.Next(50, 100);
            return result;

        }

        public void DisplayTemperature()
        {

            temperature = GetTemperatureToday();

            if (temperature > 90)
            {
                Console.WriteLine($"It will be very hot today. The forecast is: {temperature} degrees!");
            }
            else if (temperature > 80)
            {
                Console.WriteLine($"It will be hot today. The forecast is: {temperature} degrees");
            }
            else if (temperature > 70)
            {
                Console.WriteLine($"It will be calm today. The forecast is: {temperature} degrees");
            }
            else if (temperature > 60)
            {
                Console.WriteLine($"It will be cool today. The forecast is: {temperature} degrees");
            }
            else
            {
                Console.WriteLine($"It will be cold today. The forecast is: {temperature} degrees");
            }


        }


    }
}
