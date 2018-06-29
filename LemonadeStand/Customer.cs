using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {

        
        
        public int buyChance;

        public Customer()
        {
            
            

        }

        public Customer(Random r)
        {
            buyChance = r.Next(40, 61);
        }
       

        public void buyChanceWeather()
        {

        }













    }
}

