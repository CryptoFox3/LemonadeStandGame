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

        public double AddMoney(double moneyToAdd, Inventory inventory)
        {
            inventory.money = inventory.money + moneyToAdd;
            return inventory.money;
        }

        public double RemoveMoney(double moneyToRemove, Inventory inventory)
        {
            inventory.money = inventory.money - moneyToRemove;
            return inventory.money;
        }

        public void ShowMoney(Inventory inventory)
        {
            Console.WriteLine("Your current balance is: " + inventory.money);
        }

        public void ShowItems(Inventory inventory)
        {
            Console.WriteLine($"Your current inventory is: \n Cups: {cups}\n Ice: {ice}\n Sugar: {sugar}\n Lemons {lemon}");
        }

    }
}













           

        
         
