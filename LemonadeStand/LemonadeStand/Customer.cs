using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer 
    {
        //member variables
        public double priceLimit;
        public string name;

        //constructor
        //does this need parameters?
        public Customer()
        {
           // this.pricePreference = pricePreference;
        }

        //methods
       public void GetRandomPricePreference(int minimum, int maximum, Random rnd)
        {
            int tempPricePreference = rnd.Next(5,20);
            priceLimit =  (tempPricePreference / 10.0);
          
        } 

    }
}

     

