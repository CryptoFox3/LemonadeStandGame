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

        public void ShowMoney(Player player)
        {
            Console.WriteLine("Your current balance is: " + player.inventory.money);
        }

        public void ShowItems(Player player)
        {
            Console.WriteLine($"Your current inventory is: \n Cups: {cup}\n Ice: {ice}\n Sugar: {sugar}\n Lemons {lemon}");
        }

        public void CheatItems(Player player)
        {
            Console.WriteLine("Item cheat: Please enter how many of each item you would like to add to your inventory:");
            int cheatAmount = Convert.ToInt32(Console.ReadLine());
            lemon = lemon + cheatAmount;
            cup = cup + cheatAmount;
            ice = ice + cheatAmount;
            sugar = sugar + cheatAmount;
            ShowItems(player);
            Console.ReadKey();
        }

    }
}













           

        
         
