using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {


        public List<Customer> customers = new List<Customer>();
        public Customer customer = new Customer();
        public Weather weather = new Weather();
        public RandomNumber RNG = new RandomNumber();
        public int sales;
        
        

        public Day()
        {


        }



        public void GenerateCustomers()
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
                customers.Add(customer);
            }

        }




        public void StartDay(Player player)
        {
            weather.WeatherToday();
            GenerateCustomers();
            DidCustomerBuy(player);
            Sales(player);

            

        }

        public void FirstDay(Player player)
        {
            weather.WeatherToday();
        }

        public void Sales(Player player)
        {
            Console.WriteLine($"Out of {customers.Count()} potential customers, we made {sales} total sales today.");
            double revenue = player.salePrice * sales;
            Console.WriteLine($"This is equal to a total revenue of {revenue}");
            Console.ReadLine();


        }

        public void DidCustomerBuy(Player player)

        {

            int min = 1;
            int max = 100;

            if (player.inventory.lemonade > 1)
            {
                for (int i = 0; i < customers.Count; i++)
                    if (customer.buyChance >= RNG.RandomNumberGenerator(min, max))
                    {
                        player.inventory.lemonade--;
                        sales++;
                    }
            }
            else
            {
                player.recipe.MakeLemonade(player);
                DidCustomerBuy(player);
            }

        }

        












    }
}

    
    


