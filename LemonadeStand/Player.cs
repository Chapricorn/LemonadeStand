using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        public int cashTotal;
     
        public void CreatePlayerName()
        {
            name = name;
            cashTotal = 0;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(" Name: {0}", name);
        }
        public void Wallet()
        {
            Console.WriteLine("Your have = $20.00 in your Wallet");
        }

    }
}
