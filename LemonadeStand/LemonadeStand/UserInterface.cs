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
            Console.WriteLine("Welcome to the world of entrpeanuership! \n As you play this game, you will see if you have what it takes to own and operate your own lemonade stand. \n  You will need to make decisions about how much lemonade to prepare as well as what price point to set it at. \n You will get a daily forcast to help you plan. \n But beware!  As we all know, weather is prone to change! \n");
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("This is the default recipe for lemonade(per pitcher): \n \n Lemons: 2 \n Sugar: 6 cups \n Ice: 2 trays \n \n Would you like to change the recipe?  Press 1 to change, press 2 to keep going with the current recipe.");
        }

       public void DisplayInventory(Player player)
        {
            Console.WriteLine("\nYour Current Inventory:\n Lemons: " + player.inventory.lemons + "\nCups of Sugar: " + player.inventory.cupsOfSugar + "\nTrays of Ice: " + player.inventory.bagsOfIce);
        }
        public void DisplayStorePrices()
        {
           Console.WriteLine("\n \n At the store: \n Price per lemon = $0.25. \n Price per bag of ice = $2.00 \n Price per package of Sugar = $1.00"); 
       }
        public void DisplayWalletBalance(Player player)
        {
            Console.WriteLine("\nYou currently have $" + player.wallet.cash);
        } 
      
    }
}
