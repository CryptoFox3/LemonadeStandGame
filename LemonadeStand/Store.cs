using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {

        double cupCost = 00.10;
        double iceCost = 00.05;
        double sugarCost = 00.50;
        double lemonCost = 00.50;


        public Store()
        {
            //    name = player.name();
        }

        public void ShopMenu(Inventory inventory)
        {
            Console.Clear();
            //  Console.WriteLine("Welcome to the shop " + name);

            Console.WriteLine("SHOP MENU\n========\nPlease choose an option below:\n'Buy Cups', 'Buy Ice', 'Buy Sugar', 'Buy Lemons'  'Inventory', 'Money'. 'Main Menu'");
            string menuChoice = Console.ReadLine().ToLower();


            switch (menuChoice)
            {
                case "buy cups":
                    //Console.WriteLine();
                    BuyCup(inventory, cupCost);
                    Console.ReadLine();
                    ShopMenu(inventory);
                    break;
                case "buy ice":
                    BuyIce(inventory, iceCost);
                    Console.ReadLine();
                    ShopMenu(inventory);
                    break;
                case "buy sugar":
                    BuySugar(inventory, sugarCost);
                    Console.ReadLine();
                    ShopMenu(inventory);
                    break;
                case "buy lemons":
                    BuyLemon(inventory, lemonCost);
                    Console.ReadLine();
                    ShopMenu(inventory);
                    break;
                case "inventory":
                    inventory.ShowItems(inventory);
                    Console.ReadKey();
                    ShopMenu(inventory);
                    break;
                case "money":
                    inventory.ShowMoney(inventory);
                    Console.WriteLine();
                    Console.ReadKey();
                    ShopMenu(inventory);
                    break;
                case "main menu":
                    //Game.MainMenu();
                    break;
                default:
                    Console.WriteLine("Try again!");
                    ShopMenu(inventory);
                    break;
            }
        }


        public void BuyCup(Inventory inventory, double cupCost)
        {
            Console.WriteLine($"Cups cost: {cupCost} \n How many would you like to buy?");
            double boughtCups = Convert.ToDouble(Console.ReadLine());
            
            double moneyToRemove = boughtCups * cupCost;
            Console.WriteLine($"You have bought {boughtCups} cups for {moneyToRemove} dollar(s)");
            Console.ReadLine();
            inventory.RemoveMoney(moneyToRemove, inventory);

            inventory.cups = Convert.ToInt32(inventory.cups + boughtCups);
            ShopMenu(inventory);
        }

        public void BuyIce(Inventory inventory, double iceCost)
        {
            Console.WriteLine($"Ice costs: {iceCost} \n How much would you like to buy?");
            double boughtIce = Convert.ToInt32(Console.ReadLine());

            double moneyToRemove = boughtIce * iceCost;
            Console.WriteLine($"You have bought {boughtIce} ice for {moneyToRemove} dollar(s)");
            Console.ReadLine();
            inventory.RemoveMoney(moneyToRemove, inventory);

            inventory.ice = Convert.ToInt32(inventory.ice + boughtIce);
            ShopMenu(inventory);
        }

        public void BuySugar(Inventory inventory, double cupCost)
        {
            Console.WriteLine($"Sugars cost: {sugarCost} \n How many would you like to buy?");
            double boughtSugar = Convert.ToDouble(Console.ReadLine());

            double moneyToRemove = boughtSugar * sugarCost;
            Console.WriteLine($"You have bought {boughtSugar} sugar for {moneyToRemove} dollars()");
            Console.ReadLine();
            inventory.RemoveMoney(moneyToRemove, inventory);

            inventory.cups = Convert.ToInt32(inventory.sugar + boughtSugar);
            ShopMenu(inventory);
        }
        public void BuyLemon(Inventory inventory, double cupCost)
        {
            Console.WriteLine($"Lemons cost: {cupCost} \n How many would you like to buy?");
            double boughtLemons = Convert.ToDouble(Console.ReadLine());

            double moneyToRemove = boughtLemons * lemonCost;
            Console.WriteLine($"You have bought {boughtLemons} cups for {moneyToRemove} dollar(s)");
            Console.ReadLine();
            inventory.RemoveMoney(moneyToRemove, inventory);

            inventory.cups = Convert.ToInt32(inventory.lemon + boughtLemons);
            ShopMenu(inventory);
        }



        public static void BuySugar()
        {

        }
    }
}

