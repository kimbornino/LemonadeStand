using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        //memmber variables
       
        public Player player;
        public Day day;
        public Store store;
        

        public Game()
        {
            day = new Day();
            player = new Player();
            store = new Store();
        }
        

       
        //GetActualForecast
        //playDay
        //TotalProfits
        //DisplayProfits
        //DecideToDoNextRound

        public void RunGame()
        {
            
            var rules = new UserInterface();
            rules.DisplayRules();
            day.weather.Getforecast();
            //player.changeRecipe();
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

        }
    }
}
