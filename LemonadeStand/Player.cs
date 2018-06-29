using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        string Name;

        public Inventory inventory = new Inventory();
        Recipe recipe = new Recipe();
        

        public string playerName()
        {
            return Name = GetPlayerName();
                
        }

        //============================ CHANGE/CONTINUE
        public Recipe ChangeRecipe(Recipe recipe)
        {

            return recipe;
        }
        //============================ CHANGE/CONTINUE

        //public Inventory GetInventory()
        //{
        //    Inventory inventory = new Inventory();
        //   return inventory;
        //}

      

        public string GetPlayerName()
        {
            Console.WriteLine("Please enter your name: ");
            return Console.ReadLine();
        }
    }
}
