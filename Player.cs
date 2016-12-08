using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand2
{
    class Player
    {
        public string name;
        Wallet wallet;
        Stand stand;
        Inventory inventory;
        public double totalExpense;

        public Player()
        {
            wallet      = new Wallet();
            stand       = new Stand();
            inventory   = new Inventory();
        }

        public void DisplayDailyResults()
        {
            // Add Logic to WriteLine for the DailyResults list
            Console.WriteLine(" \n Daily Balance" );
            foreach (Inventory item in DailyResults)
            {
                Console.WriteLine("  Balance of Cups {0} ", item.balanceOfCups);
                Console.WriteLine("  Balance of Ice Cubes {0} ", item.balanceOfIce);
                Console.WriteLine("  Balance of Lemons {0} ", item.balanceOfLemons);
                Console.WriteLine("  Balance of Water Bottles {0} ", item.balanceOfWaterBottles);
                Console.WriteLine("  Balance of Sugar Cubes {0} ", item.balanceOfSugarCubes);
                Console.WriteLine(" \n ");
            }
        }

        public void SellLemonades()
        {
            Customer customer = new Customer();
            Console.WriteLine(" Congrats, you have Customers waiting in line. \n");
            Console.WriteLine(" Please help your Customers. ");
            Console.WriteLine(" How many cups of Lemonades did all your Customers buy?. ");
            try
            {
                int item = Convert.ToInt32(Console.ReadLine());
                customer.BuyLemonade = item;
                customer.TotalCost = item * stand.pricePerCup;
               
            }
            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry ");
                Console.WriteLine(" Please try Again. ");
            }

            Console.WriteLine(" Enter Customer Name. \n");
            try
            {
                customer.CustomerName = Console.ReadLine();                              
            }
            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry ");
                Console.WriteLine(" Please try Again!");
            }



            // add the toltal of sells to wallet
            wallet.CurrentBalance = wallet.CurrentBalance + customer.TotalCost;


            // deduct the total cup of lemonades sold from the total of sells
            inventory.totalCupsOfLemonades = inventory.totalCupsOfLemonades - customer.BuyLemonade;

            DisplayTotalBalance();
        }

        public void EnterName()
        {
            Console.WriteLine(" Please ENTER your Name to Start \n ");
            name = Console.ReadLine();
            if (name.Equals(""))
            {
                Console.WriteLine(" Please ENTER your Name! \n");
                EnterName();
            }

        }


        /// <summary>
        /// this method used to display the balance from the wallet and the total expenses after player buy items
        /// </summary>
        public void DisplayTotalBalance()
        {
            Console.WriteLine(" \n Total Expense  ${0} ", totalExpense);
            Console.WriteLine(" Current Balance ${0} ", wallet.CurrentBalance);
            Console.WriteLine(" ");

        }
        public double BuyCups()
        {
            Console.WriteLine(" How many Cups do you want to buy? \n");

            try
            {
                double item = Convert.ToDouble(Console.ReadLine());
                if (wallet.CurrentBalance > stand.PricePerCup * item)
                {
                    wallet.CurrentBalance = wallet.CurrentBalance - (stand.PricePerCup * item);
                    inventory.balanceOfCups += (stand.numberOfCups * item);
                    Console.WriteLine(" There are {0} Empty cups in your Shopping Cart \n", inventory.balanceOfCups);
                   
                    // compute the total expense
                    totalExpense = totalExpense + stand.PricePerCup * item;
                    DisplayTotalBalance();


                }
                else if (wallet.CurrentBalance < stand.PricePerCup * item)
                {
                    Console.WriteLine(" Sorry {0} you don't have enough cash in your Wallet ", name);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry ");
                Console.WriteLine(" Please use Numbers ONLY!");
                BuyCups();
            }

            return wallet.CurrentBalance;
        }
        public double BuyLemons()
        {
            Console.WriteLine(" How many lemons you want to buy? \n");
            try
            {
                double item = Convert.ToDouble(Console.ReadLine());
                if (wallet.CurrentBalance > stand.PricePerLemon * item)
                {
                    wallet.CurrentBalance = wallet.CurrentBalance - (stand.PricePerLemon * item);
                    inventory.balanceOfLemons += (stand.numberOfLemons * item);
                    wallet.displayCurrentBalance();
                    Console.WriteLine(" There are {0} Lemons in your Shopping Cart \n", inventory.balanceOfLemons);

                    // compute the total expense
                    totalExpense = totalExpense + stand.PricePerLemon * item;
                    DisplayTotalBalance();

                }
                else if (wallet.CurrentBalance < stand.PricePerLemon * item)
                {
                    Console.WriteLine(" Sorry {0} you don't have enough cash in your Wallet ", name);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry ");
                Console.WriteLine(" Please use Numbers ONLY! ");
                BuyLemons();
            }
            return wallet.CurrentBalance;
        }
        public double BuyWater()
        {
            Console.WriteLine(" How many Water bottles do you want to buy? \n ");
            try
            {
                double item = Convert.ToDouble(Console.ReadLine());
                if (wallet.CurrentBalance > stand.PricePerWater * item)
                {
                    wallet.CurrentBalance = wallet.CurrentBalance - (stand.PricePerWater * item);
                    inventory.balanceOfWaterBottles += (stand.numberOfWaters * item);
                    Console.WriteLine(" There are {0} Bottles of water in your Shopping Cart \n", inventory.balanceOfWaterBottles);

                    // compute the total expense
                    totalExpense = totalExpense + stand.PricePerWater * item;
                    DisplayTotalBalance();

                }
                else if (wallet.CurrentBalance < stand.PricePerWater * item)
                {
                    Console.WriteLine(" Sorry {0} you don't have enough cash in your Wallet ", name);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry ");
                Console.WriteLine(" Please use Numbers ONLY! ");
                BuyWater();
            }

            return wallet.CurrentBalance;
        }

        public double BuyIce()
        {
            Console.WriteLine(" How many Ice Cubes do you want? \n");
            try
            {
                double item = Convert.ToDouble(Console.ReadLine());

                if (wallet.CurrentBalance > stand.PricePerIce * item)
                {
                    wallet.CurrentBalance = wallet.CurrentBalance - (stand.PricePerIce * item);
                    inventory.balanceOfIce += (stand.numberOfIce * item);
                    Console.WriteLine(" There are {0} Ice Cubes in your Shopping Cart \n", inventory.balanceOfIce);

                    // compute the total expense
                    totalExpense = totalExpense + stand.PricePerIce * item;
                    DisplayTotalBalance();

                }
                else if (wallet.CurrentBalance < stand.PricePerIce * item)
                {
                    Console.WriteLine(" Sorry {0} you don't have enough cash in your Wallet ", name);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry ");
                Console.WriteLine(" Please use Numbers ONLY!");
                BuyIce();
            }
            return wallet.CurrentBalance;
        }

        public double BuySugars()
        {
            Console.WriteLine(" How many Sugar Cubes do you want to buy? \n");
            try
            {
                double item = Convert.ToDouble(Console.ReadLine());
                if (wallet.CurrentBalance > stand.PricePerSugar * item)
                {

                    wallet.CurrentBalance = wallet.CurrentBalance - (stand.PricePerSugar * item);
                    inventory.balanceOfSugarCubes += (stand.numberOfSugar * item);
                    Console.WriteLine(" There are {0} Sugar Cubes in your Shopping Cart \n", inventory.balanceOfSugarCubes);

                    // compute the total expense
                    totalExpense = totalExpense + stand.PricePerCup * item;
                    DisplayTotalBalance();


                }
                else if (wallet.CurrentBalance < stand.PricePerSugar * item)
                {
                    wallet.displayCurrentBalance();
                    inventory.SupplyBalance();
                    Console.WriteLine(" Sorry {0} you don't have enough cash in your Wallet ", name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry ");
                Console.WriteLine(" Please use Numbers ONLY! ");
                BuySugars();
            }
            return wallet.CurrentBalance;
        }


        //public Inventory Result = new Inventory();
        public List<Inventory> DailyResults = new List<Inventory>();


        public void MakeLemonades()

        {
            inventory.SupplyBalance();

            // save daily result inventory to a list
            Inventory newInventory = new Inventory();
            newInventory.balanceOfCups = inventory.balanceOfCups;
            newInventory.balanceOfWaterBottles = inventory.balanceOfWaterBottles;
            newInventory.balanceOfLemons = inventory.balanceOfLemons;
            newInventory.balanceOfSugarCubes = inventory.balanceOfSugarCubes;
            newInventory.balanceOfIce = inventory.balanceOfIce;
            //newInventory.totalCupsOfLemonades = inventory.totalCupsOfLemonades;
            //newInventory.cupsOfLemonadesSold = inventory.cupsOfLemonadesSold;
            // add daily inventory to a list
            DailyResults.Add(newInventory);


            wallet.displayCurrentBalance();
            {
                {
                    inventory.totalCupsOfLemonades  = inventory.totalCupsOfLemonades    + 10;
                    inventory.balanceOfLemons       = inventory.balanceOfLemons         - 4;
                    inventory.balanceOfSugarCubes   = inventory.balanceOfSugarCubes     - 2;
                    inventory.balanceOfIce          = inventory.balanceOfIce            - 8;
                    inventory.balanceOfWaterBottles = inventory.balanceOfWaterBottles   - 1;
                    inventory.balanceOfCups         = inventory.balanceOfCups           - 10;

                    Console.WriteLine(" There are {0} cup(s) of Lemonade(s). \n", inventory.totalCupsOfLemonades);
                    inventory.SupplyBalance();

                    


                }
            }
        }
                    public void MakeMoreLemonades()
        {
            Console.WriteLine(" Want to make more Lemonades? Yes | No \n");
            string MakeMore = Console.ReadLine().ToLower();
            if (MakeMore == " Yes ")
            {
            }
            else if (MakeMore == " No ")
            {
                Console.WriteLine("Great Good luck on your sales! \n");
            }
            else
            {
                Console.WriteLine(" Invalid Entry! ");
                MakeMoreLemonades();
            }
        }
        }

  
    }








