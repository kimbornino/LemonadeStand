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
        public Customer customers;
        public int weatherValue;


        public Game()
        {
            rnd = new Random();
            day = new Day();
            player = new Player();
            store = new Store();
            // already has been instantiatedcustomers = new Customer();

        }

        //TotalProfits
        //DisplayProfits
        //DecideToDoNextRound

        public void DetermineNumberOfCustomers()
        {
            weatherValue = day.weather.tempIndex + day.weather.conditionIndex;
            weatherValue = 8;
            if (weatherValue > 7)
            {
                for (int i = 1; i <= 40; i++)
                {
                    Customer C = new Customer();
                    C.GetRandomPricePreference(1, 20, rnd);
                    
                    if (C.pricePreference <= player.lemonadePrice)
                    {
                        day.customers.Add(C);

                    }
                }
                
             }
            else if (weatherValue > 5 && weatherValue < 8)
            {
                for (int i = 1; i <= 30; i++)
                {
                    day.customer.GetRandomPricePreference(1, 20, rnd);
                    if (day.customer.pricePreference <= player.lemonadePrice)
                    {
                        day.customers.Add(day.customer);
                    }
                }
            }
            else if (weatherValue > 3 && weatherValue < 6)
            {
                for (int i = 1; i <= 20; i++)
                {
                    day.customer.GetRandomPricePreference(1, 20, rnd);
                    if (day.customer.pricePreference <= player.lemonadePrice)
                    {
                        day.customers.Add(day.customer);
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    day.customer.GetRandomPricePreference(1, 20, rnd);
                    if (day.customer.pricePreference <= player.lemonadePrice)
                    {
                        day.customers.Add(day.customer);
                    }
                }
            }
        }
    
        
    public void RunGame()

    {

        var rules = new UserInterface();
        rules.DisplayRules();
        day.weather.Getforecast();
        var recipe = new UserInterface();
        recipe.DisplayRecipe();
        var price = new UserInterface();
        price.DisplayStorePrices();
        var displayWallet = new UserInterface();
        displayWallet.DisplayWalletBalance(player);
        var displayInventory = new UserInterface();
        displayInventory.DisplayInventory(player);
        player.GetSuppliesRequest();
        store.SellItems(player);
        store.TakeMoney(player);
        displayWallet.DisplayWalletBalance(player);
        displayInventory.DisplayInventory(player);
        player.MakeLemonade();
        player.SetLemonadePrice();
        day.weather.GetActualWeather();
        DetermineNumberOfCustomers();
        Console.WriteLine(day.customers);
    }
    

    }
}

