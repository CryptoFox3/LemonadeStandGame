using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    class Recipe
    {
        int sugarInRecipe = 3;
        int cupsInRecipe = 12;
        int lemonsInRecipe = 3;
        int iceInRecipe = 4;
        




        public void ChangeRecipe(Recipe recipe, Player player)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the recipe editor " + player.Name);
            Console.WriteLine("Your recipe makes 12 cups of lemonade at a time.");
            Console.WriteLine("RECIPE MENU\n========\nPlease choose an option below:\n 'Ice', 'Sugar', 'Lemons', 'Recipe' 'Inventory', 'Money', 'Main Menu'");
            string menuChoice = Console.ReadLine().ToLower();

            switch (menuChoice) {
                case "ice":
                    Console.WriteLine($"Your recipe currently uses {iceInRecipe} ice per pitcher, please enter how much ice you would like to use");
                    iceInRecipe = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine($"Your recipe is now set to use {iceInRecipe} ice");
                    Console.ReadKey();
                    ChangeRecipe(player.recipe, player);
                    break;
                case "sugar":
                    Console.WriteLine($"Your recipe currently uses {sugarInRecipe} sugar per pitcher, please enter how much sugar you would like to use");
                    sugarInRecipe = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine($"Your recipe is now set to use {sugarInRecipe} sugar");
                    Console.ReadKey();
                    ChangeRecipe(player.recipe, player);
                    break;
                case "lemons":
                    Console.WriteLine($"Your recipe currently uses {lemonsInRecipe} lemons, please enter how many lemons you would like to use");
                    lemonsInRecipe = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine($"Your recipe is now set to use {lemonsInRecipe} lemons");
                    Console.ReadKey();
                    ChangeRecipe(player.recipe, player);
                    break;
                case "recipe":
                    ShowRecipe(player.recipe, player);
                    Console.ReadKey();
                    ChangeRecipe(player.recipe, player);
                    break;
                case "inventory":
                    player.inventory.ShowItems(player);
                    Console.WriteLine();
                    Console.ReadKey();
                    ChangeRecipe(player.recipe, player);
                    break;
                case "money":
                    player.inventory.ShowMoney(player);
                    Console.ReadKey();
                    break;
                case "main menu":
                    break;
                default:
                    break;
            }
            

            
        }
        public void ShowRecipe(Recipe recipe, Player player)
        {
            Console.WriteLine($"Your current recipe is: \n Ice: {iceInRecipe}\n Sugar: {sugarInRecipe}\n Lemons {lemonsInRecipe} \n Cups: {cupsInRecipe}");
        }

        public void MakeLemonade(Player player)
        {
            if (player.inventory.sugar >= sugarInRecipe && player.inventory.lemon >= lemonsInRecipe && player.inventory.ice >= iceInRecipe && player.inventory.cup >= cupsInRecipe)
            {
            player.inventory.sugar = player.inventory.sugar - sugarInRecipe;
            player.inventory.lemon = player.inventory.lemon - lemonsInRecipe;
            player.inventory.ice = player.inventory.ice - iceInRecipe;
            player.inventory.cup = player.inventory.cup - cupsInRecipe;
            player.inventory.lemonade = player.inventory.lemonade + 12;

                }
                else
                {
                    Console.WriteLine("You have sold out of ingredients");
                    
                }
            

        }

       




    }


}
