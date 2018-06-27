using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {

        public Store()
        {
            //    name = player.name();
        }

        public void ShopMenu()
        {
            Console.Clear();
          //  Console.WriteLine("Welcome to the shop " + name);

            Console.WriteLine("SHOP MENU\n========\nPlease choose an option below:\n'Buy Cups', 'Inventory', 'Money'. 'Start Day'");
            string menuChoice = Console.ReadLine().ToLower();


            switch (menuChoice)
            {
                case "store":
                    Console.WriteLine();
                    Console.ReadLine();
                    ShopMenu();
                    break;
                case "inventory":
                    //           inventory.ShowItems();
                    Console.WriteLine();
                    Console.ReadKey();
                    ShopMenu();
                    break;
                case "money":
                    //         inventory.ShowMoney();
                    Console.WriteLine();
                    Console.ReadKey();
                    ShopMenu();
                    break;
                case "start day":
                    Console.WriteLine("Not yet implimented");
                    //       game.MainMenu();
                    break;
                default:
                    Console.WriteLine("Try again!");
                    //    MainMenu();
                    break;
            }









        }
    }
}
