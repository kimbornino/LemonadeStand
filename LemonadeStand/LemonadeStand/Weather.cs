using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        //member vairables
       
        public string condition;
        public string temperature;
        public string forecast;
        public string actualWeather;
        public List<string> conditionsString;
        public List<string> temp;
        //methodsure

        //constrctor
        public Weather()
        {
            conditionsString = new List<string>() {"Rainy", "Cloudy", "Sunny", "Humid"};
            temp = new List<string>() {"50-60", "60-70", "70-80", "80-90"};
            SetUpWeather();
            
        }
        //methods
  

        public void GetTemp()
            {
                Random rnd = new Random();
                int randomtemp = rnd.Next(0, 4); // creates a number between 0 and 3 
                temperature = temp[randomtemp];
                //tempIndex = 
            }


            void GetCondition()
            {
                Random rnd = new Random();
                int RandomCondition = rnd.Next(0, 4); //creates a number between 0 and 3
                condition = conditionsString[RandomCondition];
            }

        public void SetUpWeather()
        {
            GetTemp();
            GetCondition();
        }
        public string Getforecast()
        {

            Console.WriteLine("\n \n The forecast is " + temperature + " degrees "+ "and" + " " + condition + ".");
            return forecast;
        }

        public string GetActualWeather()
        {
            Random rnd = new Random();
            int mayChange = rnd.Next(1, 4); //creates a number between 1 and 3

            if (mayChange == 1)
            {
                int randomtemp = rnd.Next(0, 4); // creates a number between 0 and 3 
                temperature = temp[randomtemp];

            }
            else if (mayChange == 2)
            {
                int RandomCondition = rnd.Next(0, 4); //creates a number between 0 and 3
                condition = conditionsString[RandomCondition];
            }
            Console.WriteLine("\n \n Good Morning!  The actual weather today is " + temperature + " degrees " + "and" + " " + condition + ".");
            return actualWeather;
        }
    }
}

