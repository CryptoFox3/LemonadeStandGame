using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class RandomNumber
    {
        Random r = new Random();

        public RandomNumber()
        {
            
        }
        

        public int RandomNumberGenerator(int min, int max)
        {
            Random r = new Random();
            int output = r.Next(min, max); 
            return output;
        }

    }
}
