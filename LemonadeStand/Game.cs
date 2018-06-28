using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //Store store;  
        //public Game()
        //{
        Store store = new Store();
        Player player = new Player();
        
        Weather weather = new Weather();
        //}


        public int gameLength = 7;
        public int gameDay;
        public string name;

        public void Start()
        {
            name = player.playerName();
            //Inventory inventory = player.GetInventory();
            gameDay = 1;
            MainMenu(/*player.inventory*/);
            
        }

         public void MainMenu(/*Inventory inventory*/)
        {

            Console.Clear();
            Console.WriteLine("Welcome " + name);
            Console.WriteLine("It is currently day: " + gameDay);
            Console.WriteLine("GAME MENU\n=========\nPlease choose an option below:\n'Store', 'Inventory', 'Money', 'Check Weather', 'Start Day'");
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
                    player.inventory.ShowItems(player.inventory);
                    Console.WriteLine();
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "money":
                    player.inventory.ShowMoney(player.inventory);
                    Console.WriteLine();
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "check weather":
                    weather.DisplayTemperature();
                    Console.WriteLine();
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "start day":
                    Console.WriteLine("Not yet implimented");
                    DayPhase(player.inventory);
                    break;
                default:
                    Console.WriteLine("Try again!");
                    Console.ReadKey();
                    MainMenu();
                break;
            }
        }

     

        public static void check()
        {
            //CheckInventory();
        }
        

        public void CheckInventory()
        {
           // inventory.ShowItems();

        }

        public void DayPhase(Inventory inventory)
        {
            if (gameDay < gameLength)
            {
                Day day = new Day();



                gameDay++;
                MainMenu();
            }

            else
            {
                EndGame();
            }

                
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
