using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet : Player
    {
        public string playerName;
        public double balance;
        public const double DEFAULT_BALANCE = 20.00;
        internal static StorePrices Balance;

        public Wallet()
        {
            
        }
        public Wallet(string Name, double Balance)
        {
            playerName = Name;
            balance = Balance;
            if (Balance == 0)
            {
                balance = DEFAULT_BALANCE;
            }
            else
            {
                balance = Balance;
            }


        }
        public Wallet(string Name)
        {
            playerName = Name;
            balance = DEFAULT_BALANCE;
        }
        public void SetName( string Name)
        {
            playerName = Name;
        }
        public void SetBalance(double Balance)
        {
            balance = Balance;
        }
        public string GetName()
        {
            return playerName;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}