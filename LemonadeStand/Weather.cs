using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public int weatherType;
        public int temperature;
        public int maxTempt = 100;
        public int minTempt = 50;
      

        public Weather()
        {
         
        }


        public string GetWeather()
        {

            switch (weatherType)
            {
                case 0:
                    return " Sunny and Hot ";

                case 1:
                    return " Rainy and Wet ";

                case 2:
                    return " Cloudy and Cold ";

                case 3:
                    return " Windy and Dry ";

                default:
                    return "Sunny and Hot ";

            }
        }

        //public void SetWeatherType()
        //{
        //    weatherType = random.Next(0, 4);
        //}
        //public void SetTemperature()
        //{
        //    temperature = random.Next(temperature, temperature + 1);
        //}

    }
}









        //    Random random = new Random();
        //    int randomNumber = random.Next(65, 75, 85, 95, 100);
        //    Console.WriteLine(random.Next(65));
        //    Console.WriteLine(random.Next(75));
        //    Console.WriteLine(random.Next(85));
        //    Console.WriteLine(random.Next(95));
        //    Console.WriteLine(random.Next(100));

        //    return;
        //}
//    }
//}
