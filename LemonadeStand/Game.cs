using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        
        Store store = new Store();
        Player player = new Player();
        Day Day = new Day();

       


        public int gameLength = 7;
        public int gameDay;
        public string name;

        public void Start()
        {
            player.Name = player.playerName();
            player.inventory.SetStartMoney();
            Day.FirstDay(player);
            gameDay = 1;
            MainMenu();
            
        }

         public void MainMenu()
        {

            Console.Clear();
            Console.WriteLine("Welcome " + name);
            Console.WriteLine("It is currently day: " + gameDay);
            Console.WriteLine("GAME MENU\n=========\nPlease choose an option below:\n'Store', 'Inventory', 'Recipe', 'Change Recipe', 'Money', 'Sale Price', 'Weather Forecast', 'Start Day', 'Exit'");
            string menuChoice = Console.ReadLine().ToLower();
           

            switch (menuChoice)
            {
                case "store":
                    store.ShopMenu(player);
                    Console.WriteLine();
                    Console.ReadLine();
                    MainMenu();
                    break;
                case "inventory":
                    player.inventory.ShowItems(player);
                    Console.WriteLine();
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "recipe":
                    player.recipe.ShowRecipe(player.recipe, player);
                    Console.WriteLine();
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "change recipe":
                    player.recipe.ChangeRecipe(player.recipe, player);
                    Console.WriteLine();
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "sale price":
                    Console.WriteLine($"Your sale price is currently {player.salePrice} per cup of lemonade. Please type 'change sale price' to enter a new sale price");
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "change sale price":
                    player.ChangeSalePrice();
                    Console.WriteLine();
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "money":
                    player.inventory.ShowMoney(player);
                    Console.WriteLine();
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "cheat money":
                    Console.WriteLine($"Money Cheat: {player.inventory.money} is the current balance. Enter the amount you would like to add to your balance.");
                    double moneyToAdd = Convert.ToDouble(Console.ReadLine());
                    player.inventory.AddMoney(moneyToAdd, player);
                    Console.WriteLine($"Your balance is now {player.inventory.money}");
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "weather forecast":
                    Day.weather.DisplayWeather();
                    Console.WriteLine();
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "start day":
                    Console.WriteLine("Not yet implimented");
                    DayPhase(player.inventory);
                    break;
                case "exit":
                    EndGame();
                    break;
                default:
                    Console.WriteLine("Try again!");
                    Console.ReadKey();
                    MainMenu();
                break;
            }
        }

     


        public void CheckInventory()
        {
           // inventory.ShowItems();

        }

        public void DayPhase(Inventory inventory)
        {
            if (gameDay < gameLength)
            {


                Day.StartDay(player);
                NextDay();
            }

            else
            {
                EndGame();
            }

                
        }

        public void NextDay()
        {
            Day Day = new Day();
            gameDay++;
            MainMenu();
        }


        public void EndGame()
        {
            Console.Clear();
            Console.WriteLine($"The game is over. \nWould you like to play again? Type: Yes or No.");
            string choice = Console.ReadLine().ToLower();
            {
                switch (choice)
                {

                    case ("yes"):
                        Start();
                        break;
                    case ("no"):
                        Console.WriteLine("Thanks for playing...");
                        Console.Read();
                        break;
                    default:
                        Console.WriteLine("Please try again");
                        EndGame();
                        break;
                }
            }




        }
    }
}
