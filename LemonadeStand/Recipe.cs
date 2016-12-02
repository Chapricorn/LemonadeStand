using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {


        public int lemonsRecipe;
        public int sugarRecipe;
        public int iceRecipe;

        public void ShowRecipe()
        {
            Console.WriteLine("How many lemons would you like to use?");
            int.TryParse(Console.ReadLine(), out lemonsRecipe);
            Console.WriteLine("How much sugar would you like to use?");
            int.TryParse(Console.ReadLine(), out sugarRecipe);
            Console.WriteLine("How much ice would you like to use?");
            int.TryParse(Console.ReadLine(), out iceRecipe);
        }


        //public double lemonRecipe()
        //{
        //    pricePerLemon = .05;
        //}

    }

}