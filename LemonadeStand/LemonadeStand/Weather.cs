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

        //methods

        //constrctor
        public Weather()
        {
            List<string> condition = new List<string>() { "Humid", "Sunny", "Cloudy", "Rainy" };
            List<string> temp = new List<string>() { "80-90", "70-80", "60-70", "50-60" };

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
    }
}

