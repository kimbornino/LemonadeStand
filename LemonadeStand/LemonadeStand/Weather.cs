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
        //forecast
        public string condition;
        public string temperature;
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
            //GetForcast();
            //GetActual();
            GetTemp();
            GetCondition();
        }
        public void Getforecast()
        {

            Console.WriteLine("\n \n The forecast is " + temperature + " degrees "+ "and" + " " + condition + ".");
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

