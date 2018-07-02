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
            
            
        }

        public int BuyChance()
        {
            int min = 42;
            int max = 60;
            buyChance = RNG.RandomNumberGenerator(min, max);
            return buyChance;
        }

       
        

        //public int BuyChanceWeatherEffect(int buyChance)
        //{
        //    if ()

            //return buyChance;
        //}













    }
}

