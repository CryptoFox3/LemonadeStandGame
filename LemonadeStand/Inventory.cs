using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {


        public int ice;
        public int cups;
        public int sugar;
        public int lemon;
        public double money;




        public void AddLemon()
        {

            //Lemon lemon = new Lemon { Age = 0, isRipe = true };

        }

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
            Console.WriteLine($"Your current inventory is: \n Cups: {cups}\n Ice: {ice}\n Sugar: {sugar}\n Lemons {lemon}");
        }

    }
}













           

        
         
