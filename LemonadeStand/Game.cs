using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    class Game
    {

        public Weather weather;
        public Player supplies;
        public Wallet defaultBalance;

        
        public Game()
        {
            weather = new Weather();
            supplies = new Player();
            defaultBalance = new Wallet();
        }
         
        public void StartGame()
        {
            DisplayWelcome();
            DisplayRule();
            //WeatherForcasted();
            GetPlayerName();
            TotalDays();
            //ChooseSupplies();
            //BalanceLeft();
            //SetBalance();
            supplies.BuySupplies();
            //BuyMoreSupplies();
            weather.GetWeather();
  
    }
        public void DisplayWelcome()
        {
            Console.WriteLine(" Welcome to your Neighborhood Lemonade Stand Game \n");
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
                    Console.WriteLine(" Please choose YES or NO.");
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

        //public int WeatherForcasted()
        //{
        //    Weather Forcast = new Weather();
        //    Forcast.GetWeather();
        //    return GetWeather;
        //}

        public void TotalDays()
        {
            Console.Write(" Choose between Day '1' and Day '7' to Start Selling Lemonades. \n");
            string chooseDay = Console.ReadLine();

            switch (chooseDay)
            {
                case "1":
                    Console.WriteLine(" Great, you have chosen to start on Day " + chooseDay + " You have 1 Full Week to Sell Lemonades. ");
                    Console.WriteLine(" Please press ENTER to continue.");
                    break;
                case "2":
                    Console.WriteLine(" Good, you have chosen to slack off " + chooseDay + " Days, you have 5 Days left to Sell Lemonades. ");
                    Console.WriteLine(" Please press ENTER to continue.");
                    break;
                case "3":
                    Console.WriteLine(" Ok, you have chosen to slack off " + chooseDay + " Days, you have 4 more Days to Sell Lemonades. ");
                    Console.WriteLine(" Please press ENTER to continue.");
                    break;
                case "4":
                    Console.WriteLine(" You have chosen to slack off " + chooseDay + " Days, you have 3 Days left to Sell Lemonades. ");
                    Console.WriteLine(" Please press ENTER to continue.");
                    break;
                case "5":
                    Console.WriteLine(" Awe Man!, You slacked off " + chooseDay + " Days, you have 2 Days left to Sell Lemonades. ");
                    Console.WriteLine(" Please press ENTER to continue.");
                    break;
                case "6":
                    Console.WriteLine(" Awe Man!, You slacked off " + chooseDay + " Days, Now you only have 1 Day to Sell Lemonades. ");
                    Console.WriteLine(" Please press ENTER to continue.");
                    break;
                case "7":
                    Console.WriteLine(" Wow! " + chooseDay + " Days, you are running out of time! \n");
                    break;
            }
            Console.ReadLine();
            
           
        }
    
      


        //public void BalanceLeft()
        //{
        //    Wallet GetBalance = new Wallet();
        //    GetBalance.wallet();
        //}



        //public void BuyMoreSupplies()
        //{

        //}



    
    }
}