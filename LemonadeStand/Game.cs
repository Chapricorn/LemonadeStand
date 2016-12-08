using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand2
{
    public class Game 
    {
        Player player;
        Weather weather;
        Inventory inventory;
        Day day;
        Customer customer;
        Wallet wallet;
        public Game()
        {
            player      = new Player();
            wallet      = new Wallet();
            weather     = new Weather();           
            day         = new Day();
            customer    = new Customer();
            inventory   = new Inventory();


        }

        public void StartGame()
        {
            DisplayWelcome();
            PlayerIntroduced();
            DisplayRule();
            DisplaySupplyPrice();
            DayChoice();

        }

        public void DisplayWelcome()
        {
            Console.WriteLine(" Welcome to the Neighborhood's Lemonade Stand. \n");

        }

        public void PlayerIntroduced()
        {
            player = new Player();
            player.EnterName();
            Console.WriteLine(" Good Morning {0}, my name is Master ShiFu. I see you want to sell Lemonades, Let's get started.  \n", player.name);
            Console.ReadLine();
        }
        public void DisplayRule()
        {
            Console.WriteLine(" Do you want to know the rules? Yes | No \n");
            string choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "yes":
                    Rules rule = new Rules();
                    rule.GameRules();
                    break;
                case "no":
                    Console.WriteLine(" Kool, I'm assuming you already know the rules. Now let's get Started. \n");
                    break;
                default:
                    Console.WriteLine(" Please ENTER 'Yes' | 'No' ");
                    DisplayRule();
                    break;
            }
        }

        public void DisplaySupplyPrice()
        {
            Console.WriteLine(" Here are the Supplies needed and the Prices of each Items ");
            Console.WriteLine(" You will need 2 bottles of water, 2 lemons, 5 Sugar Cubes, 5 Ice cubes, and 10 cups to make Lemonades. ");
            Console.WriteLine(" Cost Per each item: Cup: $0.10, Water bottle: $1.00, Lemon: $0.25, Sugar Cube: $.05, Ice Cube: $0.05 each \n");
            Console.WriteLine(" Press ENTER to Continue. \n");
            Console.ReadLine();
        }

        public void GetSupply()
        {
            player.totalExpense = 0; //initialize total expense to zero before buying anytyhing

            player.BuyCups();
            player.BuyWater();
            player.BuyLemons();           
            player.BuyIce();
            player.BuySugars();
            player.MakeLemonades();
            player.SellLemonades();

            // Display the daily result from DailyResults
            player.DisplayDailyResults();
        }


        public void DayChoice()
        {
            while (day.day1 < day.day7)
            {
                day.days();
                Console.WriteLine(" Congrats, it's Day {0} to sell Lemonades", day.day1);
                weather.WeatherForecast();
                weather.RndTemperature();
                GetSupply();
            }
            day.day1++;
        }
    }


}


