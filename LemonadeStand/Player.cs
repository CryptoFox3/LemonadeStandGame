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

        public string playerName()
        {
            return Name = GetPlayerName();
                
        }

        public string GetPlayerName()
        {
            Console.WriteLine("Please enter your name: ");
            return Console.ReadLine();
        }
    }
}
