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
   
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to the world of entreneurship! \n \n As you play this game, you will see if you have what it takes to own and operate your own lemonade stand. \n You will need to make decisions about how much lemonade to prepare as well as what price point to set it at. \n You will get a daily forcast to help you plan. \n But beware!  As we all know, weather is prone to change! \n");
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("Take a look at the recipe you'll use to make your lemonade. The recipe for lemonade(per pitcher) is: \n 2 lemons, 2 cups sugar, and 2 trays of ice. \n");
        }

       public void DisplayInventory(Player player)
        {
            Console.WriteLine("\nYour Current Inventory:\n Lemons: " + player.inventory.lemons + "\nCups of Sugar: " + player.inventory.cupsOfSugar + "\nTrays of Ice: " + player.inventory.bagsOfIce);
        }
        public void DisplayStorePrices()
        {
           Console.WriteLine("\n Now it's time to buy enough supplies to make your lemonade.  \n \n Store Prices: \n Price per lemon = $0.25. \n Price per tray of ice = $0.75 \n Price per package of Sugar = $0.50"); 
       }
        public void DisplayWalletBalance(Player player)
        {
            Console.WriteLine("\nYou currently have $" + player.wallet.cash);
        } 
      
    }
}
