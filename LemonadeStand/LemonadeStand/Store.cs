using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        //member variables
        double lemonCost = .25;
        double iceCost = 2.00;
        double sugarCost = 1.00;
        public Inventory inventory;

        public Store()
        {
            inventory = new Inventory();
        }

        public void SellItems(Player player)
        {
            //should be an int after getting user input
            player.inventory.lemonInventoryRequest += player.inventory.lemons;
            player.inventory.iceInventoryRequest += player.inventory.bagsOfIce;
            player.inventory.sugarInventoryRequest += player.inventory.cupsOfSugar;
        }

        public void TakeMoney(Player player)
        {
            player.wallet.cash -= (player.lemonInventoryRequest * lemonCost);
            player.wallet.cash -= (player.iceInventoryRequest * iceCost);
            player.wallet.cash -= (player.sugarINventoryRequest * sugarCost);
        }


        /*internal void GetInventory(Player player)
        {
            
        }
        */
    }
}
