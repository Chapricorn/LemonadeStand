using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand2
{
    class Wallet
    {
        public double CurrentBalance;


        public Wallet()
        {
            CurrentBalance = 30.00;

        }
        public void displayCurrentBalance()
        {
            Console.WriteLine(" Your cash balance ${0} ", CurrentBalance);
        }
    }
}
    