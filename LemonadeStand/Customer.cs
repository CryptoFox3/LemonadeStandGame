using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {


        RandomNumber RNG = new RandomNumber();

        public int buyChance;


        public Customer()
        {
            GenerateCustomer();
            
        }

       

        public void BuyChance()
        {
            int min = 42;
            int max = 60;
            buyChance = RNG.RandomNumberGenerator(min, max);
        }
       


        public void BuyChanceWeather()
        {


        }













    }
}

