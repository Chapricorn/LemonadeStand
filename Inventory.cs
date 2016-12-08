using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand2
{
    class Inventory
    {

        public double balanceOfCups         = 0;
        public double balanceOfWaterBottles = 0;
        public double balanceOfLemons       = 0;
        public double balanceOfSugarCubes   = 0;
        public double balanceOfIce          = 0;
        public double totalCupsOfLemonades  = 0;
        public double cupsOfLemonadesSold   = 0;
        

        public void SupplyBalance()
        {
            Console.WriteLine(" Shopping Cart: {0} bottles of Water, {1} Lemons, {2} Ice Cubes, {3} Empty Cups, {4} Sugar Cubes \n");
            Console.WriteLine("", balanceOfCups, balanceOfWaterBottles, balanceOfLemons, balanceOfIce, balanceOfSugarCubes);

           
        }
    }
}


