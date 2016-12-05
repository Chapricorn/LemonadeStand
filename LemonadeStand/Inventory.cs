using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public double waterLeft = 0;
        public double lemonLeft = 0;
        public double iceLeft = 0;
        public double cupLeft = 0;
        public double sugarLeft = 0;
        public double lemonadeCup;
        public int lemonadeLeft;
        public double cash;
        public int maxCups = 10;
        public double startingCash = 20.00;


        public void Supplies()
        {

            lemonadeLeft = 0;
            cash = startingCash;
        }

        public Inventory()
        {
            lemonadeCup = 0;
        }
        public void AddWater()
        {
            return;
        }
        public void CurrentSupplies()
        {
            Console.WriteLine("Your current supplies: {0} bottles of water, {1} Lemons, {2} ice, {3} cups, {4} sugar \n", waterLeft, lemonLeft, iceLeft, cupLeft, sugarLeft);
        }


    }
}