using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    class Wallet : Player
    {
        public string player;
        public double balance;
        public double currentBalance;
        Player totalCostOfCup = new Player();
        Player TotalBalance = new Player();


        public void SetBalance(double Balance)
        {
            balance = Balance;
        }
        public string GetPlayer()
        {
            return player;
        }


        //        private void BalanceLeft()
        //        {
        //            double totalsupplyCost;
        //            double DefaultBalance;
        //            double result;
        //            totalsupplyCost = Convert.ToDouble(Console.ReadLine());
        //            DefaultBalance = Convert.ToDouble(Console.ReadLine());
        //            result = DefaultBalance - totalsupplyCost;
        //            Console.Write(" Do you want to Continue Shopping?");
        //            Console.ReadLine();

        //            return BalanceLeft;

    }
}
//}
//public int inWallet(int priceOfWater, int priceOfLemon, int priceOfCup, int priceOfIce, int priceOfSugar)
//{
//    int RemainningBalance;
//    RemainningBalance = priceOfWater - priceOfLemon - priceOfCup - priceOfIce - priceOfSugar;
//    return RemainningBalance;
//}




//{
//    currentBalance = 30.00;

//}




//    player = Name;
//    balance = Balance;
//    if (Balance == 0)
//    {
//        balance = DEFAULT_BALANCE;
//    }
//    else
//    {
//        balance = Balance;
//    }
//}
//    public double BalanceLeft()
//    {
//        //player = Name;
//        balance = DEFAULT_BALANCE;
//    }

//    public double CurrentBalance()
//    {

//        return currentBalance;
//    }

//}



