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
        public Store store;


        //public Wallet()
        //{
        //    currentBalance = 20.00;

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
        //public Wallet(string Name)
        //{
        //    player = Name;
        //    balance = DEFAULT_BALANCE;
        //}

        public double CurrentBalance()
        {

            return currentBalance;
        }

    }
}

    //}
    //public void SetBalance(double Balance)
    //{
    //    balance = Balance;
    //}
    //public string GetPlayer()
    //    {
    //        return player;
    //    }

    //}
