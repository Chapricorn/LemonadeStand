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
        public void GetPlayerName()
        {
            Player player = new LemonadeStand.Player();
            player.CreatePlayerName();
            Console.WriteLine(" Please Enter your Name");
            string CharacterName = Console.ReadLine();
            Console.WriteLine(" Good Morning {0} ", CharacterName + "!");
        }
        public void TotalDays()
        {
            Console.Write(" Choose between Day '1' and Day '7' to Start Selling Lemonades. \n");
            string chooseDay = Console.ReadLine();

            switch (chooseDay)
            {
                case "1":
                    Console.WriteLine(" Great, you have chosen to start on Day " + chooseDay + " You have 1 Full Week to Sell Lemonades. ");
                    Console.WriteLine("Please press ENTER to continue.");
                    break;
                case "2":
                    Console.WriteLine(" Good, you have chosen to slack off " + chooseDay + " Days, you have 5 Days left to Sell Lemonades. ");
                    Console.WriteLine("Please press ENTER to continue.");
                    break;
                case "3":
                    Console.WriteLine(" Ok, you have chosen to slack off " + chooseDay + " Days, you have 4 more Days to Sell Lemonades. ");
                    Console.WriteLine("Please press ENTER to continue.");
                    break;
                case "4":
                    Console.WriteLine(" You have chosen to slack off " + chooseDay + " Days, you have 3 Days left to Sell Lemonades. ");
                    Console.WriteLine("Please press ENTER to continue.");
                    break;
                case "5":
                    Console.WriteLine(" Awe Man!, You slacked off " + chooseDay + " Days, you have 2 Days left to Sell Lemonades. ");
                    Console.WriteLine("Please press ENTER to continue.");
                    break;
                case "6":
                    Console.WriteLine(" Awe Man!, You slacked off " + chooseDay + " Days, Now you only have 1 Day to Sell Lemonades. ");
                    Console.WriteLine("Please press ENTER to continue.");
                    break;
                case "7":
                    Console.WriteLine(" Wow! " + chooseDay + " Days, you are running out of time! ");
                    Console.WriteLine("Please press ENTER to continue.");
                    break;
            }
            Console.ReadLine();

        }

        public void BuySupplies()
        {
            Console.WriteLine("Please buy all required Supplies to make Lemonade.");

            // create a new storeprice object named storeSupplies
            StorePrices newStoreSupplies = new LemonadeStand.StorePrices();


            // start enter number of supplies here ...
            Console.WriteLine("Enter number of Cups: ");
            newStoreSupplies.Cups = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter number of Lemons: ");
            newStoreSupplies.Lemons = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter number of Ice: ");
            newStoreSupplies.Ice = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter number of Sugars: ");
            newStoreSupplies.Sugars = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of Waters: ");
            newStoreSupplies.Waters = Convert.ToInt32(Console.ReadLine());

            // buy supplies
            newStoreSupplies.BuySupplies();

            // display result
            //Console.WriteLine("TotalCups       : " + storeSupplies.Cups);
            Console.WriteLine("TotalCostOfCup  : " + newStoreSupplies.TotalCostOfCup);
            Console.WriteLine("TotalCostOfIce  : " + newStoreSupplies.TotalCostOfIce);
            Console.WriteLine("TotalCostOfLemon: " + newStoreSupplies.TotalCostOfLemon);
            Console.WriteLine("TotalCostOfSugar: " + newStoreSupplies.TotalCostOfSugar);
            Console.WriteLine("TotalCostOfWater: " + newStoreSupplies.TotalCostOfWater);
            Console.WriteLine("TotalsupplyCost : " + newStoreSupplies.TotalsupplyCost);

        }
        public void BuyMoreSupplies()
        {
            Console.WriteLine();
            Console.ReadLine();
        }

    }
}

