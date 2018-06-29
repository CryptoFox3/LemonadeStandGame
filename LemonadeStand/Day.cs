﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {


        List<Customer> customers = new List<Customer>();
        public Weather weather = new Weather();
        RandomNumber RNG = new RandomNumber();
        

        public Day()
        {

            
        }

        public void GenerateCustomer()
        {
            int min = 80;
            int max = 150;

            if (weather.temperatureToday > 70 && weather.temperatureToday < 85)
            {
                min += 15;
                max += 15;
            }
            else if (weather.temperatureToday > 85)
            {
                min += 10;
                max += 10;
            }
            else if (weather.temperatureToday < 65)
            {
                min -= 15;
                max -= 15;
            }

            int numberOfCustomers = RNG.RandomNumberGenerator(min, max);

            for (int i = 0; i < numberOfCustomers; i++)
            {      
                customers.Add(new Customer());
            }

        }




        public void StartDay()
        {
            weather.WeatherToday();
            GenerateCustomer();
            Sales();

        }

        public void Sales()
        {
            Console.WriteLine(customers.Count());
            Console.ReadKey();
            customers.Clear();

        }





      






    }

    


}
