using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand2
{
    class Day
    {
        Inventory inventory;
        public double numberOfCustomer;
        Weather weather;
        public double day1;
        public double day7;


        public Day()
        {
            day1 = 0;
            day7 = 7;
            inventory   = new Inventory();
            weather     = new Weather();
            numberOfCustomer = 0;

        }

        public double days()
        {
            day1 += 1;
            return day1;
        }

        //public double CustomerPerDay(double customersPerWeather)
        //{
        //    if (weather.temperatures        == 1)
        //    {
        //        numberOfCustomer            = 20;
        //    }
        //    else if (weather.temperatures   == 2)
        //    {
        //        numberOfCustomer            = 15;
        //    }
        //    else if (weather.temperatures   == 3)
        //    {
        //        numberOfCustomer            = 10;
        //    }
        //    else if (weather.temperatures   == 4)
        //    {
        //        numberOfCustomer            = 5;
        //    }
        //    return numberOfCustomer;
        //}


    }
}
