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
        public Wallet wallet;
        public Store store;


        //public Player()
        //{
        //    wallet = new Wallet();
        //    store = new Store();

        //}


        public void CreatePlayerName()
        {
            name = name;
            cashTotal = 0;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(" Name: {0}", name);
        }
        public void InWallet()
        {
            Console.WriteLine(" You are starting out only with $30.00 in your Wallet.");
        }
        public void BuySupplies()

        {
            Console.WriteLine(" Please buy all required Supplies to make Lemonade. \n");


            Store storeSupplies = new Store();
            try
            {
                Console.WriteLine(" Enter number of Cups you want to buy: ");
                Console.WriteLine(" Cost for '1' Empty Cup is $.10. \n");
                storeSupplies.cups = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(" \n Total Cost : $" = - store.priceOfCup);
                //wallet.GetBalance = store.priceOfCup - storeSupplies.cups;
            }

            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry");
                Console.WriteLine(" Please use Numbers ONLY!");
            }
            try
            {

                Console.WriteLine(" Enter number of Lemons you want to buy: ");
                Console.WriteLine(" Cost for '1' Lemon is $.75. \n");
                storeSupplies.lemons = Convert.ToInt32(Console.ReadLine());
               
            }

            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry");
                Console.WriteLine(" Please use Numbers ONLY!");
            }
            try
            {


                Console.WriteLine(" Enter number of Ice Cubes you want to buy: ");
                Console.WriteLine(" Cost for '1' Ice Cube is $.05. \n");
                storeSupplies.ice = Convert.ToInt32(Console.ReadLine());
                
            }
            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry");
                Console.WriteLine(" Please use Numbers ONLY!");
            }
            try
            {

                Console.WriteLine(" Enter number bags of Sugars you want to buy: ");
                Console.WriteLine(" Cost for '1' Bag of Sugar is $1.50. \n");
                storeSupplies.sugars = Convert.ToInt32(Console.ReadLine());
               
            }

            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry");
                Console.WriteLine(" Please use Numbers ONLY!");
      
            }
            try
            {

                Console.WriteLine(" Enter number of bottled Waters you want to buy: ");
                Console.WriteLine(" Cost for '1' Bottled Water is $1.75. \n");
                storeSupplies.waters = Convert.ToInt32(Console.ReadLine());
               

            }
                catch (Exception e)
                {
                    Console.WriteLine(" Invalid Entry");
                    Console.WriteLine(" Please use Numbers ONLY!");
         
                }

                Console.WriteLine("\n Your Reciept. \n");


            storeSupplies.CalculateSupplies();

            Console.WriteLine(" Total of Cups bought             : " + storeSupplies.cups);
            Console.WriteLine(" Total Cost of Cups               : $" + storeSupplies.totalCostOfCup);
            Console.WriteLine(" Total of Ice Cubes bought        : " + storeSupplies.ice);
            Console.WriteLine(" Total Cost of Ice                : $" + storeSupplies.totalCostOfIce);
            Console.WriteLine(" Total of Lemons bought           : " + storeSupplies.lemons);
            Console.WriteLine(" Total Cost of Lemons             : $" + storeSupplies.totalCostOfLemon);
            Console.WriteLine(" Total bags of Sugars bought      : " + storeSupplies.sugars);
            Console.WriteLine(" Total Cost for bags of Sugars    : $" + storeSupplies.totalCostOfSugar);
            Console.WriteLine(" Total bottles of Water bought    : " + storeSupplies.waters);
            Console.WriteLine(" Total Cost of bottled Water      : $" + storeSupplies.totalCostOfWater);

            Console.WriteLine(" \n Total Cost : $" + storeSupplies.totalsupplyCost);

            }
      
        
        
        
        
        
        //public void BuyMoreSupplies()
            //{
            //    Console.WriteLine();
            //    Console.ReadLine();
            //}

        }
    }

