using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {

        public int ice { get; set; }
        public int cup { get; set; }
        public int sugar { get; set; }
        public int lemon { get; set; }
        public int lemonade { get; set; }
        public double money { get; set; }




       

        public double SetStartMoney()
        {
            return money = 20.00;
        }

        public double AddMoney(double moneyToAdd, Player player)
        {
            player.inventory.money = player.inventory.money + moneyToAdd;
            return player.inventory.money;
        }

        public double RemoveMoney(double moneyToRemove, Player player)
        {
            player.inventory.money = player.inventory.money - moneyToRemove;
            return player.inventory.money;
        }

        //public int RemoveItem(int amountToRemove, Player player)
        //{

            
      //      return player.inventory;
      //  }

        public void ShowMoney(Player player)
        {
            Console.WriteLine("Your current balance is: " + player.inventory.money);
        }

        public void ShowItems(Player player)
        {
            Console.WriteLine($"Your current inventory is: \n Cups: {cup}\n Ice: {ice}\n Sugar: {sugar}\n Lemons {lemon}");
        }

    }
}













           

        
         
