using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public int lemonadeLeft;
        public double cash;
        public int maxCups = 10;
        public double startingCash = 20.00;
        public void Supplies()
        {

            lemonadeLeft = 0;
            cash = startingCash;
        }
        //public waterBottles = new ();
        //public lemons = new ();
        //public cups = new ();
        //public sugarCups = new ();
        //public iceCubes = new ();

    }


}
