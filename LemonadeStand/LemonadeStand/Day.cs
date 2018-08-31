using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        //member variables (has a)

        public Weather weather;
        List<Customer> customers;
        public Customer customer;

        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
            customer = new Customer();

        }
        public void DetermineWeatherImpact()
        {
            int weatherValue = weather.tempIndex + weather.conditionIndex;

            if (weatherValue > 7)
            {
                for (int i = 0; i <= 40; i++)
                {
                    customers.Add(customer);
                }
            }
            if (weatherValue > 5 && weatherValue < 8)
            {
                for (int i = 0; i <= 30; i++)
                {
                    customers.Add(customer);
                }
            }
            if (weatherValue > 3 && weatherValue < 6)
            {
                for (int i = 0; i <= 20; i++)
                {
                    customers.Add(customer);
                }
            }
            else
            {
                for (int i = 0; i <= 10; i++)
                {
                    customers.Add(customer);
                }
            }
        }
    }
}
