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
        double iceCost = .75;
        double sugarCost = 1.00;
        public Inventory inventory;

        public Store()
        {
            inventory = new Inventory();
        }

        public void SellItems(Player player)
        {
            player.inventory.lemons += player.lemonInventoryRequest;
            player.inventory.bagsOfIce += player.iceInventoryRequest;
            player.inventory.cupsOfSugar += player.sugarInventoryRequest; 
        }

        public void TakeMoney(Player player)
        {
            player.wallet.cash -= (player.lemonInventoryRequest * lemonCost);
            player.wallet.cash -= (player.iceInventoryRequest * iceCost);
            player.wallet.cash -= (player.sugarInventoryRequest * sugarCost);
        }
    }
}
