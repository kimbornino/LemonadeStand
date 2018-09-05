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
        public int tempIndex;
        public int conditionIndex;
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
                tempIndex = rnd.Next(0, 4); // creates a number between 0 and 3 
                temperature = temp[tempIndex];
            Console.WriteLine(tempIndex);
                
               }


            public void GetCondition()
            {
                Random rnd = new Random();
                conditionIndex = rnd.Next(0, 4); //creates a number between 0 and 3
                condition = conditionsString[conditionIndex];
            }

        public void SetUpWeather()
        {
            GetTemp();
            GetCondition();
        }
        public string Getforecast()
        {

           SetUpWeather();
            Console.WriteLine("\nThe forecast is " + temperature + " degrees "+ "and" + " " + condition + ".");
            return forecast;
        }

        public string GetActualWeather()
        {
            Random rnd = new Random();
            int mayChange = rnd.Next(1, 4); //creates a number between 1 and 3

            if (mayChange == 1)
            {
                int tempIndex = rnd.Next(0, 4); // creates a number between 0 and 3 
                temperature = temp[tempIndex];

            }
            else if (mayChange == 2)
            {
                int conditionIndex = rnd.Next(0, 4); //creates a number between 0 and 3
                condition = conditionsString[conditionIndex];
            }
            Console.WriteLine("\n \n Good Morning!  The actual weather for today is " + temperature + " degrees " + "and" + " " + condition + ".");
            return actualWeather;
        }
    }
}

