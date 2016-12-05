using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class StorePrices : Inventory
    {
        Player player;
        StorePrices store;
        Inventory inventory = new Inventory();
        Wallet wallet = new Wallet();

        public double PriceOfWater;
        public double PriceOfLemon;
        public double PriceOfCup;
        public double PriceOfSugar;
        public double PriceOfIce;

        public StorePrices()
        {
            PriceOfWater = 1.00;
            PriceOfLemon = 0.10;
            PriceOfCup = 0.15;
            PriceOfSugar = 1.00;
            PriceOfIce = 0.02;
        }
        public void BuySupplies()
        {

            BuyWater();
            BuyLemon();
            BuyCup();
            BuyIce();
            BuySugar();
            CurrentSupplies();
            BuyMoreSupplies();
            //ChooseSupplies();
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
                    //inventory.waterLeft += (store.numberOfWater * item);
                    Console.WriteLine("Your balance is now : {0} \n", wallet.balance);

                }
                else if (wallet.balance < PriceOfWater * item)
                {
                    Console.WriteLine("Sorry {0} you don't have enough Wallet.\n", player.name);
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
                    //wallet.balance = wallet.balance - (PriceOfLemon * item);
                    //inventory.lemonLeft += (store.numberOfLemon * item);
                    Console.WriteLine("Your current Balance: {0}\n", wallet.balance);

                }
                else if (wallet.balance < PriceOfLemon * item)
                {
                    Console.WriteLine("Sorry {0} you don't have enough Wallet", player.name);
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
                    //inventory.cupLeft += (store.numberOfCup * item);
                    Console.WriteLine("Your current Balance: {0} \n", wallet.balance);

                }
                else if (wallet.balance < PriceOfCup * item)
                {
                    Console.WriteLine("Sorry {0} you don't have enough money in your Wallet", player.name);
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
                    //inventory.iceLeft += (store.numberOfIce * item);
                    Console.WriteLine("Your balance is now : {0} \n", wallet.balance);

                }
                else if (wallet.balance < PriceOfIce * item)
                {
                    Console.WriteLine("Sorry {0} you don't have enough money in your Wallet.", player.name);
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
                    //inventory.sugarLeft += (store.numberOfSugar * item);
                    Console.WriteLine("Your current Balance: {0} \n", wallet.balance);

                }
                else if (wallet.balance < PriceOfSugar * item)
                {
                    Console.WriteLine("Sorry {0} you don't have enough money in your Wallet", player.name);
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
   