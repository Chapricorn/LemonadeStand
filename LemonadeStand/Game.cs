using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player player;
        //Player player2;
        public void StartGame()
        {
            DisplayWelcome();
            DisplayRule();
            GetPlayerName();
            TotalDays();
            ShowRecipe();
            PlayerChoice();
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
                    break;
                case "2":
                    Console.WriteLine(" Good, you have chosen to slack off " + chooseDay + " Days, you have 5 Days left to Sell Lemonades. ");
                    break;
                case "3":
                    Console.WriteLine(" Ok, you have chosen to slack off " + chooseDay + " Days, you have 4 more Days to Sell Lemonades. ");
                    break;
                case "4":
                    Console.WriteLine(" You have chosen to slack off " + chooseDay + " Days, you have 3 Days left to Sell Lemonades. ");
                    break;
                case "5":
                    Console.WriteLine(" Awe Man!, You slacked off " + chooseDay + " Days, you have 2 Days left to Sell Lemonades. ");
                    break;
                case "6":
                    Console.WriteLine(" Awe Man!, You slacked off " + chooseDay + " Days, Now you only have 1 Day to Sell Lemonades. ");
                    break;
                case "7":
                    Console.WriteLine(" Wow! You slacked off " + chooseDay + " Days, I can't believe it! I'll just assumed you don't know how to make Lemonade? ");
                    break;
                    //}
                    Console.ReadLine();
                    Console.WriteLine("Please choose a Day to start.");
                    TotalDays();
            }
        }

        public void ShowRecipe()
        {
            Recipe
        }

        public void PlayerChoice()
        {
            player.MakeChoice();
        }
    }
}