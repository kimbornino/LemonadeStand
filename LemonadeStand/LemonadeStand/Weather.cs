using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member vairables
        public string temperature;
        public string condition;
        public int actualWeather;
        public int forecast;

        //methods

        //constrctor
        public Weather()
        {
            List<string> condition = new List<string>() {"Rainy", "Cloudy", "Sunny", "Humid"};
            List<string> temp = new List<string>() {"50-60", "60-70", "70-80", "80-90"};

        }
        //methods
        public int GetTemp()
        {
            Random rnd = new Random();
            int temperature = rnd.Next(1, 5); // creates a number between 1 and 4 
            return temperature;
        }
        public int GetCondition()
        {
            Random rnd = new Random();
            int condition = rnd.Next(1, 5); //creates a number between 1 and 4
            return condition;
        }

        public void getForecast()
        {
            Console.WriteLine("The weather forecast is:" + temperature + "and" + condition);
        }
        public void getActualWeather()
        {
            Random rnd = new Random();
            int mayChange = rnd.Next(1, 4); //creates a number between 1 and 3

            if (mayChange == 1 || mayChange == 2)
            {
         //forecast change
            }
            if (mayChange == 3)
            {
                //forecast changes
            }
        }
    }
}

