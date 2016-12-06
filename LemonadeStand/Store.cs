using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class StorePrices : Inventory
    {
        Player player = new Player();
        StorePrices store;
        Inventory inventory = new Inventory();
        Wallet wallet = new Wallet();

        // public properties
        public int Cups = 0;
        public int Waters = 0;
        public int Lemons = 0;
        public int Sugars = 0;
        public int Ice = 0;

        public double TotalCostOfWater = 0;
        public double TotalCostOfLemon = 0;
        public double TotalCostOfCup = 0;
        public double TotalCostOfSugar = 0;
        public double TotalCostOfIce = 0;
        public double TotalsupplyCost = 0;

        // constant variables
        public double numberOfWater = 1;
        public double numberOfLemon = 1;
        public double numberOfIce = 1;
        public double numberOfCup = 1;
        public double numberOfSugar = 1;
        public double PriceOfWater = 1.00;
        public double PriceOfLemon = 0.10;
        public double PriceOfCup = 0.15;
        public double PriceOfSugar = 1.00;
        public double PriceOfIce = 0.02;

       public double BuyWater(int Cup)
        {
            double TotalCost = 0;
            TotalCost = Cup * PriceOfWater;
            return TotalCost;
        }


        public double BuyLemon(int Cup)
        {
            double TotalCost = 0;
            TotalCost = Cup * PriceOfLemon;
            return TotalCost;
        }

        public double BuyCup(int Cup)
        {
            double TotalCost = 0;
            TotalCost = Cup * PriceOfCup;
            return TotalCost;
        }

        public double BuyIce(int Cup)
        {
            double TotalCost = 0;
            TotalCost = Cup * PriceOfIce;
            return TotalCost;
        }

        public double BuySugar(int Cup)
        {
            double TotalCost = 0;
            TotalCost = Cup * PriceOfSugar;
            return TotalCost;
        }


        public void BuySupplies()
        {


            TotalCostOfWater = BuyWater(this.Waters);
            TotalCostOfLemon = BuyLemon(this.Lemons);
            TotalCostOfCup = BuyCup(this.Cups);
            TotalCostOfSugar = BuySugar(this.Sugars);
            TotalCostOfIce = BuyIce(this.Ice);

            TotalsupplyCost =  
                                TotalCostOfWater +
                                TotalCostOfLemon +
                                TotalCostOfCup +
                                TotalCostOfSugar +
                                TotalCostOfIce +
                                TotalsupplyCost;

        }


        public StorePrices BuyWater()
        {      
            Console.WriteLine("How many water bottles of Water do you want? \n");
            try
            {
                double item = Convert.ToDouble(Console.ReadLine());
                if (wallet.balance > PriceOfWater * item)
                {
                    Console.WriteLine("You now have {0} water bottle \n", item);
                    wallet.balance = wallet.balance - (PriceOfWater * item);
                    inventory.waterLeft += (store.numberOfWater * item);
                    Console.WriteLine("Your balance is now : {0} \n", wallet.balance);

                }
                else if (wallet.balance < PriceOfWater * item)
                {
                    Console.WriteLine("Sorry {0} you are out of Cash.\n", player.name);
                    BuyWater();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid amount");
                Console.WriteLine("Please use Numbers ONLY!");
                BuyWater();
            }

            return Wallet.Balance;
        }


        public StorePrices BuyLemon()
        {
            Console.WriteLine("How many lemon do you want to buy? \n");
            try
            {
                double item = Convert.ToDouble(Console.ReadLine());
                if (wallet.balance > PriceOfLemon * item)
                {
                    Console.WriteLine("You now have {0} of lemon \n", item);
                    wallet.balance = wallet.balance - (PriceOfLemon * item);
                    inventory.lemonLeft += (store.numberOfLemon * item);
                    Console.WriteLine("Your current Balance: {0}\n", wallet.balance);

                }
                else if (wallet.balance < PriceOfLemon * item)
                {
                    Console.WriteLine("Sorry {0} you are out of Cash.", player.name);
                    BuyLemon();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You enter a invalid amount");
                Console.WriteLine("Please use Numbers ONLY!");
                BuyLemon();
            }
            return Wallet.Balance;

        }

        public StorePrices BuyCup()
        {
            Console.WriteLine("How many cups do you want? \n");
            try
            {
                double item = Convert.ToDouble(Console.ReadLine());
                if (wallet.balance > PriceOfCup * item)
                {
                    Console.WriteLine("You now have {0} of cup \n", item);
                    wallet.balance = wallet.balance - (PriceOfCup * item);
                    inventory.cupLeft += (store.numberOfCup * item);
                    Console.WriteLine("Your current Balance: {0} \n", wallet.balance);

                }
                else if (wallet.balance < PriceOfCup * item)
                {
                    Console.WriteLine("Sorry {0} you are out of Cash.", player.name);
                    BuyCup();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You enter a invalid amount");
                Console.WriteLine("Please use Numbers ONLY!");

                BuyCup();
            }
            return Wallet.Balance;

        }

        public StorePrices BuyIce()
        {
            Console.WriteLine("How many ice cubes do you want? \n");
            try
            {
                double item = Convert.ToDouble(Console.ReadLine());

                if (wallet.balance > PriceOfIce * item)
                {
                    Console.WriteLine("You now have {0} of ice \n", item);
                    wallet.balance = wallet.balance - (PriceOfIce * item);
                    inventory.iceLeft += (store.numberOfIce * item);
                    Console.WriteLine("Your balance is now : {0} \n", wallet.balance);

                }
                else if (wallet.balance < PriceOfIce * item)
                {
                    Console.WriteLine("Sorry {0} you are out of Cash.", player.name);
                    BuyIce();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You enter a invalid amount");
                Console.WriteLine("Please use Numbers ONLY!");
                BuyIce();
            }
            return  Wallet.Balance;

        }

        public StorePrices BuySugar()
        {
            Console.WriteLine("How many bags of sugar do you want? \n");
            try
            {
                double item = Convert.ToDouble(Console.ReadLine());
                if (wallet.balance > PriceOfSugar * item)
                {
                    Console.WriteLine("You now have {0} bag of sugar \n", item);
                    wallet.balance = wallet.balance - (PriceOfSugar * item);
                    inventory.sugarLeft += (store.numberOfSugar * item);
                    Console.WriteLine("Your current Balance: {0} \n", wallet.balance);

                }
                else if (wallet.balance < PriceOfSugar * item)
                {
                    Console.WriteLine("Sorry {0} you are out of Cash.", player.name);
                    BuySugar();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid amount");
                Console.WriteLine("Please use Number ONLY!");
                BuySugar();
            }
            return Wallet.Balance;

        }

        public void BuyMoreSupplies()
        {
            bool buymore = true;
            while (buymore)
            {
                Console.WriteLine("Do you want more supplies? Yes | No \n");
                string more = Console.ReadLine().ToLower();


                if (more == "yes")
                {
                    buymore = true;
                    Console.WriteLine("Choose which one: Water, Lemon, Ice, Cup, Sugar? \n");
                    string pick = Console.ReadLine().ToLower(); ;
                    if (pick == "water")
                    {
                        BuyWater();
                    }
                    else if (pick == "lemon")
                    {
                        BuyLemon();
                    }
                    else if (pick == "ice")
                    {
                        BuyIce();
                    }
                    else if (pick == "cup")
                    {
                        BuyCup();
                    }
                    else if (pick == "sugar")
                    {
                        BuySugar();
                    }

                }
                else if (more == "no")
                {
                    Console.ReadLine();
                    buymore = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }

    }
}
   