using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string Name;

        public Inventory inventory = new Inventory();
        public Recipe recipe = new Recipe();
        public double salePrice = 0.20;
        public int totalProfit;

        public string playerName()
        {
            return Name = GetPlayerName();
                
        }

       

        public string GetPlayerName()
        {
            Console.WriteLine("Please enter your name: ");
            return Console.ReadLine();
        }

        public void ChangeSalePrice()
        {
            Console.WriteLine($"Your sale price is currently {salePrice} per cup of lemonade. Please enter a new sale price");
            double newSalePrice = Convert.ToDouble(Console.ReadLine());
            if (newSalePrice <= 1.00 && newSalePrice >= 0.05)
            {
                salePrice = newSalePrice;
                Console.WriteLine($"The price is now {salePrice} per cup");
            }
            else
            {
                Console.WriteLine("Sorry! That amount is out of range. Please enter a sale price equal to or less than $1.00");
                ChangeSalePrice();
            }
        }
    }
}
