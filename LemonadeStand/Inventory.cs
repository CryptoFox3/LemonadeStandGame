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
        public double money;




        public void AddLemon()
        {

            //Lemon lemon = new Lemon { Age = 0, isRipe = true };

        }

        public double SetStartMoney()
        {
            return money = 20.00;
        }

        public double AddMoney(double moneyToAdd, double money)
        {
            return money + moneyToAdd;
        }

        public double removeMoney(double moneyToRemove, double money)
        {
            return money + moneyToRemove;
        }

        public void ShowMoney()
        {
            Console.WriteLine("You current balance is: " + money);
        }

        public void ShowItems()
        {
            Console.WriteLine("Your current inventory is: \n Cups: " + cups + "\n Ice: " + ice + "\n Sugar: " + sugar + "\n Lemons");
        }

        











    }

    
}
