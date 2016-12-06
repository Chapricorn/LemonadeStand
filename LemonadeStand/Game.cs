using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    //public Player player;
    //public StorePrices store;
    class Game
    {
        public void StartGame()
        {
            DisplayWelcome();
            DisplayRule();
            GetPlayerName();
            TotalDays();
            //ChooseSupplies();
            BuySupplies();


        }
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Lemonade Stand Game \n");
        }
        public void DisplayRule()
        {
            Console.WriteLine(" Would you like to see the rules? Yes | No \n");
            string choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "yes":
                    Rules rule = new Rules();
                    rule.GameRules();
                    break;
                case "no":
                    Console.WriteLine(" Kool, I'm assuming you already know the Rules, Lets get Started! \n");
                    break;
                default:
                    Console.WriteLine("Please choose YES or NO.");
                    DisplayRule();
                    break;
            }
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
            
            //TotalDays();
        }







        //public void ChooseSupplies()
        //{
        //    Console.WriteLine("Please Choose the Supplies to make Lemonade.");
        //    Console.ReadLine();
        //    StorePrices storeSupplies = new LemonadeStand.StorePrices();
        //    storeSupplies.BuySupplies();

        //}
        public void BuySupplies()
        {
            Console.WriteLine("Please buy all required Supplies to make Lemonade.");
 
            // create a new storeprice object name storeSupplies
            StorePrices storeSupplies = new LemonadeStand.StorePrices();


            // start enter number of supplies here ...
            Console.WriteLine("Enter number of Cups: ");
            storeSupplies.Cups = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter number of Lemons: ");
            storeSupplies.Lemons = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter number of Ice: ");
            storeSupplies.Ice = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter number of Sugars: ");
            storeSupplies.Sugars = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of Waters: ");
            storeSupplies.Waters = Convert.ToInt32(Console.ReadLine());
                   
           // buy supplies
            storeSupplies.BuySupplies();

            // display result
            //Console.WriteLine("TotalCups       : " + storeSupplies.Cups);
            Console.WriteLine("TotalCostOfCup  : " + storeSupplies.TotalCostOfCup);
            Console.WriteLine("TotalCostOfIce  : " + storeSupplies.TotalCostOfIce);
            Console.WriteLine("TotalCostOfLemon: " + storeSupplies.TotalCostOfLemon);
            Console.WriteLine("TotalCostOfSugar: " + storeSupplies.TotalCostOfSugar);
            Console.WriteLine("TotalCostOfWater: " + storeSupplies.TotalCostOfWater);
            Console.WriteLine("TotalsupplyCost : " + storeSupplies.TotalsupplyCost);

        }
        public void BuyMoreSupplies()
        {
            Console.WriteLine();
            Console.ReadLine();
        }
        
    }
}