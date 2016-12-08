using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand2
{
    class Weather
    {
        public double temperature;
        public string weatherType;
        public double temperatures;
        Random ChooseWeather = new Random();
        public Weather()
        {
        }

        public string WeatherForecast()
        {
            temperatures            = ChooseWeather.Next(1, 5);

            if (temperatures        == 1)
            {
                weatherType         = " Sunny ";
            }
            else if (temperatures   == 2)
            {
                weatherType         = " Cloudy ";
            }
            else if (temperatures   == 3)
            {
                weatherType         = " Windy ";
            }
            else if (temperatures   == 4)
            {
                weatherType         = " Raining ";
            }
            Console.WriteLine(" The Weather today will be {0} ", weatherType);
            return weatherType;
        }
        public double RndTemperature()
        {
            temperature = ChooseWeather.Next(50, 100);
            Console.WriteLine(" But, the Temperature is about {0} degrees. ", temperature);
            Console.WriteLine(" \n ");
            Console.WriteLine(" Now lets go shopping! ");
            Console.WriteLine(" \n ");
            return temperature;

        }
    }
}