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
        public string choice;
        public void CreatePlayerName()
        {
            name = name;
            cashTotal = 0;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(" Name: {0}", name);
        }
        public void AddCash()
        {

        }
        public string MakeChoice()
        {
            Console.WriteLine(" Choose Ingredients for Lemonades. \n");
            string choice = Console.ReadLine();

            if (choice == "Lemons")
            {
                Console.WriteLine(" How many Lemons?");
                AddCash();
            }
            if (choice == "Cups")
            {
                Console.WriteLine(" How many Cups?");
                AddCash();
            }
            if (choice == "Ice")
            {
                Console.WriteLine(" How many Ice Cubes?");
                AddCash();
            }
            if (choice == "Sugar")
            {
                Console.WriteLine(" How many bags of Sugars?");
                AddCash();
            }
            if (choice == "WaterBottles")
            {
                Console.WriteLine(" How many Water Bottles?");
                AddCash();
            }
            return choice;
        }
    }
}


       
  



