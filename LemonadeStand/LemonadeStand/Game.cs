using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        //memmber variables (HAS A)
        public Random rnd;
        public Player player;
        public Day day;
        public Store store;
        public int numberOfCustomers;
        public double profits;


        public Game()
        {
            rnd = new Random();
            day = new Day();
            player = new Player();
            store = new Store();
        }

        public void DetermineNumberOfCustomers()
        {
           int weatherValue = (day.weather.tempIndex + day.weather.conditionIndex);
            //int numberOfCustomers;  
            if (weatherValue == 6)
            {
                //numberOfCustomers = 30;
                for (int i = 1; i <= 30; i++)
                {
                    Customer C = new Customer();
                    C.GetRandomPricePreference(5, 20, rnd);
                    
                    if (C.priceLimit >= player.lemonadePrice)
                    {
                        day.customers.Add(C);
                        
                    }
                }
                
             }
            else if (weatherValue >= 4 && weatherValue < 6)
            {
                for (int i = 1; i <= 20; i++)
                {
                    Customer C = new Customer();
                    C.GetRandomPricePreference(5, 20, rnd);
                    if (C.priceLimit >= player.lemonadePrice)
                    {
                        day.customers.Add(C);
                    }
                }
            }
            else if (weatherValue > 1 && weatherValue <= 3)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Customer C = new Customer();
                    C.GetRandomPricePreference(5, 20, rnd);
                    if (C.priceLimit >= player.lemonadePrice)
                    {
                        day.customers.Add(C);
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    Customer C = new Customer();
                    C.GetRandomPricePreference(5, 20, rnd);
                    if 
                        (C.priceLimit >= player.lemonadePrice)
                    {
                        day.customers.Add(C);
                    }
                }
               
            }
           // FillCustomerList(numberOfCustomers);

            numberOfCustomers = day.customers.Count;
            if (numberOfCustomers <= player.cupsOfLemonade)
            {
                Console.WriteLine("Today your store had " + numberOfCustomers + " customers." );
            }
            if (numberOfCustomers >= player.cupsOfLemonade)
            {
                numberOfCustomers = player.cupsOfLemonade;
                Console.WriteLine("You sold out!  You sold all of your lemonade to " + numberOfCustomers + " people.");
            }
            // day.customers = null;
        }
       
        public double GetProfits()
        {
            profits = (numberOfCustomers * player.lemonadePrice); 
            Console.WriteLine("You earned $" + profits + ".  Please press enter to continue");

            Console.ReadLine();
         
            return profits;
        }

        public void AddToWallet()
        {
            player.wallet.cash += profits;
        }

        public void EndGame()
        {
            Console.WriteLine("You have reached the end of the 7th day.  Time to close the lemonade stand. Your final balance was $ " + player.wallet.cash + ". Please play again!");
        }

        public void RunDay()
        {
            day.customers = new List<Customer>();
            day.weather.Getforecast();
            var recipe = new UserInterface();
            recipe.DisplayRecipe();
            var price = new UserInterface();
            price.DisplayStorePrices();
            var displayWallet = new UserInterface();
            displayWallet.DisplayWalletBalance(player);
            var displayInventory = new UserInterface();
            displayInventory.DisplayInventory(player);
            store.CheckPlayerSolvency(player);
            store.BuyLemons(player);
            store.BuyIce(player);
            store.BuySugar(player);
            store.SellItems(player);
            displayWallet.DisplayWalletBalance(player);
            displayInventory.DisplayInventory(player);
            player.MakeLemonade();
            player.SetLemonadePrice();
            player.validateLemonadePrice();
            day.weather.GetActualWeather();
            DetermineNumberOfCustomers();
            GetProfits();
            AddToWallet();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
        }
        public void RunGame()

    {
        var rules = new UserInterface();
        rules.DisplayRules();
            int days = 1;
            while (days <= 7)
            {
                Console.WriteLine("\n \n Time to get ready for tomorrow!"); 
                RunDay();
                days++;
            }
            EndGame();
        
    }

    }
}

