using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store : Inventory
    {
        Player player = new Player();
        Store store;
        Inventory inventory = new Inventory();
        //Wallet wallet = new Wallet();

        public int cups     = 0;
        public int waters   = 0;
        public int lemons   = 0;
        public int sugars   = 0;
        public int ice      = 0;

        public double totalCostOfWater  = 0;
        public double totalCostOfLemon  = 0;
        public double totalCostOfCup    = 0;
        public double totalCostOfSugar  = 0;
        public double totalCostOfIce    = 0;
        public double totalsupplyCost   = 0;


        public double numberOfWater     = 1;
        public double numberOfLemon     = 1;
        public double numberOfIce       = 1;
        public double numberOfCup       = 1;
        public double numberOfSugar     = 1;
        public double priceOfWater      = 1.75;
        public double priceOfLemon      = 0.75;
        public double priceOfCup        = 0.10;
        public double priceOfSugar      = 1.50;
        public double priceOfIce        = 0.05;


        public double PriceOfCups()
        {
            return priceOfCup;
        }

        public double BuyWater(int Cup)
        {
            double TotalCost = 0;
            TotalCost = Cup * priceOfWater;
            return TotalCost;
        }


        public double BuyLemon(int Cup)
        {
            double TotalCost = 0;
            TotalCost = Cup * priceOfLemon;
            return TotalCost;
        }

        public double BuyCup(int Cup)
        {
            double TotalCost = 0;
            TotalCost = Cup * priceOfCup;
            return TotalCost;
        }

        public double BuyIce(int Cup)
        {
            double TotalCost = 0;
            TotalCost = Cup * priceOfIce;
            return TotalCost;
        }

        public double BuySugar(int Cup)
        {
            double TotalCost = 0;
            TotalCost = Cup * priceOfSugar;
            return TotalCost;
        }


        public void CalculateSupplies()
        {


            totalCostOfWater = BuyWater(this.waters);
            totalCostOfLemon = BuyLemon(this.lemons);
            totalCostOfCup = BuyCup(this.cups);
            totalCostOfSugar = BuySugar(this.sugars);
            totalCostOfIce = BuyIce(this.ice);

            totalsupplyCost =  
                                totalCostOfWater +
                                totalCostOfLemon +
                                totalCostOfCup +
                                totalCostOfSugar +
                                totalCostOfIce +
                                totalsupplyCost;

        }


        //public Store BuyWater()
        //{      
        //    Console.WriteLine("How many water bottles of Water do you want? \n");
        //    try
        //    {
        //        double item = Convert.ToDouble(Console.ReadLine());
        //        if (wallet.balance > priceOfWater * item)
        //        {
        //            Console.WriteLine("You now have {0} water bottle \n", item);
        //            wallet.balance = wallet.balance - (priceOfWater * item);
        //            inventory.waterLeft += (store.numberOfWater * item);
        //            Console.WriteLine("Your balance is now : {0} \n", wallet.balance);

        //        }
        //        else if (wallet.balance < priceOfWater * item)
        //        {
        //            Console.WriteLine("Sorry {0} you are out of Cash.\n", player.name);
        //            BuyWater();
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Invalid amount");
        //        Console.WriteLine("Please use Numbers ONLY!");
        //        BuyWater();
        //    }

        //    return Wallet.DefaultBalance;
        //}


        //public Store BuyLemon()
        //{
        //    Console.WriteLine("How many lemon do you want to buy? \n");
        //    try
        //    {
        //        double item = Convert.ToDouble(Console.ReadLine());
        //        if (wallet.balance > priceOfLemon * item)
        //        {
        //            Console.WriteLine("You now have {0} of lemon \n", item);
        //            wallet.balance = wallet.balance - (priceOfLemon * item);
        //            inventory.lemonLeft += (store.numberOfLemon * item);
        //            Console.WriteLine("Your current Balance: {0}\n", wallet.balance);

        //        }
        //        else if (wallet.balance < priceOfLemon * item)
        //        {
        //            Console.WriteLine("Sorry {0} you are out of Cash.", player.name);
        //            BuyLemon();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("You enter a invalid amount");
        //        Console.WriteLine("Please use Numbers ONLY!");
        //        BuyLemon();
        //    }
        //    return Wallet.DefaultBalance;

        //}

        //public Store BuyCup()
        //{
        //    Console.WriteLine("How many cups do you want? \n");
        //    try
        //    {
        //        double item = Convert.ToDouble(Console.ReadLine());
        //        if (wallet.balance > priceOfCup * item)
        //        {
        //            Console.WriteLine("You now have {0} of cup \n", item);
        //            wallet.balance = wallet.balance - (priceOfCup * item);
        //            inventory.cupLeft += (store.numberOfCup * item);
        //            Console.WriteLine("Your current Balance: {0} \n", wallet.balance);

        //        }
        //        else if (wallet.balance < priceOfCup * item)
        //        {
        //            Console.WriteLine("Sorry {0} you are out of Cash.", player.name);
        //            BuyCup();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("You enter a invalid amount");
        //        Console.WriteLine("Please use Numbers ONLY!");

        //        BuyCup();
        //    }
        //    return Wallet.DefaultBalance;

        //}

        //public Store BuyIce()
        //{
        //    Console.WriteLine("How many ice cubes do you want? \n");
        //    try
        //    {
        //        double item = Convert.ToDouble(Console.ReadLine());

        //        if (wallet.balance > priceOfIce * item)
        //        {
        //            Console.WriteLine("You now have {0} of ice \n", item);
        //            wallet.balance = wallet.balance - (priceOfIce * item);
        //            inventory.iceLeft += (store.numberOfIce * item);
        //            Console.WriteLine("Your balance is now : {0} \n", wallet.balance);

        //        }
        //        else if (wallet.balance < priceOfIce * item)
        //        {
        //            Console.WriteLine("Sorry {0} you are out of Cash.", player.name);
        //            BuyIce();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("You enter a invalid amount");
        //        Console.WriteLine("Please use Numbers ONLY!");
        //        BuyIce();
        //    }
        //    return  Wallet.DefaultBalance;

        //}

        //public Store BuySugar()
        //{
        //    Console.WriteLine("How many bags of sugar do you want? \n");
        //    try
        //    {
        //        double item = Convert.ToDouble(Console.ReadLine());
        //        if (wallet.balance > priceOfSugar * item)
        //        {
        //            Console.WriteLine("You now have {0} bag of sugar \n", item);
        //            wallet.balance = wallet.balance - (priceOfSugar * item);
        //            inventory.sugarLeft += (store.numberOfSugar * item);
        //            Console.WriteLine("Your current Balance: {0} \n", wallet.balance);

        //        }
        //        else if (wallet.balance < priceOfSugar * item)
        //        {
        //            Console.WriteLine("Sorry {0} you are out of Cash.", player.name);
        //            BuySugar();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Invalid amount");
        //        Console.WriteLine("Please use Number ONLY!");
        //        BuySugar();
        //    }
        //    return Wallet.DefaultBalance;

        //}

        //public void BuyMoreSupplies()
        //{
        //    bool buymore = true;
        //    while (buymore)
        //    {
        //        Console.WriteLine("Do you want more supplies? Yes | No \n");
        //        string more = Console.ReadLine().ToLower();


        //        if (more == "yes")
        //        {
        //            buymore = true;
        //            Console.WriteLine("Choose which one: Water, Lemon, Ice, Cup, Sugar? \n");
        //            string pick = Console.ReadLine().ToLower(); ;
        //            if (pick == "water")
        //            {
        //                BuyWater();
        //            }
        //            else if (pick == "lemon")
        //            {
        //                BuyLemon();
        //            }
        //            else if (pick == "ice")
        //            {
        //                BuyIce();
        //            }
        //            else if (pick == "cup")
        //            {
        //                BuyCup();
        //            }
        //            else if (pick == "sugar")
        //            {
        //                BuySugar();
        //            }

        //        }
        //        else if (more == "no")
        //        {
        //            Console.ReadLine();
        //            buymore = false;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid choice");
        //        }
        //    }
        //}

    }
}
   