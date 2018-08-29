using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        //member variables
        public string rules;
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to the world of entrpeanuership!" +
                "As you play this game, you will see if you have what it takes to own and operate your own lemonade stand." +
                "You will need to make decisions about how much lemonade to prepare as well as what price point to set it at." +
                "You will get a daily forcast to help you plan.  But beware!  As we all know, weather is prone to change!  Alright.  If you're ready to start making money, press enter");
        }
        //display recipe.  Ask user of they would like to alter recipe
        public void diplayStorePrices()
        {
            Console.WriteLine("Price per lemon = $0.25. \n Price per bag of ice = $2.00 \n Price per package of Sugar = $1.00"); 
       }
        //This class should contain things a user can see and minilpuate in the console.
    }
}
