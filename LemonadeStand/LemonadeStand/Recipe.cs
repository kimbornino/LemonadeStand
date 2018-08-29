    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        //member variables 

        public int tasteValue;
        public int lemonValue;
        public int sugarValue;
        public int iceValue;
        double lemonAmount;
        double sugarAmount;
        double iceAmount;


        public int DetermineLemonValue()
        {
            if (lemonAmount == 1)
            {
                lemonValue = lemonValue + 1;
            }
            if (lemonAmount == 2)
            {
                lemonValue = lemonValue + 1;
            }
            if (lemonAmount == 3)
            {
                lemonValue = lemonValue = 3;
            }
            if (lemonAmount > 3)
            {
                lemonValue = 0;
                Console.WriteLine("This is too sour!");
            }

            return lemonValue;
        }

        public int DetermineSugarValue()
        {
            if (sugarAmount == 0 - 5)
            {
                sugarValue = sugarValue + 1;
            }
            if (lemonAmount == 6 - 8)
            {
                sugarValue = sugarValue + 1;
            }
            if (lemonAmount == 9 - 10)
            {
                sugarValue = sugarValue = 3;
            }
              
            if (lemonAmount > 10)
            {
                sugarValue = 0;
                Console.WriteLine("This is so sweet my teeth hurt!");
            }
               
            return sugarValue;
        }

        public int DetermineIceValue()
        {
            if (iceAmount < 1)
            {
                iceValue = iceValue + 1;
            }
            if (iceAmount == 2)
            {
                iceValue = iceValue + 2;
            }

            if (iceAmount == 3)
            {
                iceValue = iceValue + 3;
            }

            if (lemonAmount > 1)
            {
                iceValue = 0;
                Console.WriteLine("I dont like my lemonade watered down!");
            }
            return iceValue;

        }
        public int GetTotalTasteValue()
        {
            tasteValue = (lemonValue + iceValue + sugarValue);
            return tasteValue;
        }
        //method to let user create own recipe
        // give value depending on how much supply used === higher outcome for customers.
    }
}


