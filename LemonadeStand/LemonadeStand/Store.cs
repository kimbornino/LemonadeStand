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
        double sugarCost = .50;
        public Inventory inventory;

        public Store()
        {
            inventory = new Inventory();
        }

        public void SellItems(Player player)
        {
            {
                player.inventory.lemons += player.lemonInventoryRequest;
                player.inventory.bagsOfIce += player.iceInventoryRequest;
                player.inventory.cupsOfSugar += player.sugarInventoryRequest;

            }           
        }

        //try to turn each into its own method so there can be a check for enough money // public void TakeMoney(Player player)

        public void BuyLemons(Player player)
        {

            player.GetLemonRequest();

            if (player.wallet.cash > (player.lemonInventoryRequest * lemonCost))
            {
                player.wallet.cash -= (player.lemonInventoryRequest * lemonCost);
            }

            //small bug here.  Console responds that "0" is invalid request even though it is accepted in game.
            else if (player.wallet.cash < (player.lemonInventoryRequest * lemonCost) && player.lemonInventoryRequest != 0)
            {
                Console.WriteLine("You do not have enough money for this.  Please revise your request or enter 0.");
                BuyLemons(player);
            }
            else if (player.lemonInventoryRequest == 0)
            {

            }
        }

        public void BuyIce(Player player)
        {
            player.GetIceRequest();
            if (player.wallet.cash > (player.iceInventoryRequest * iceCost))
            {
                player.wallet.cash -= (player.iceInventoryRequest * iceCost);
            }

            //small bug here.  Console responds that "0" is invalid request even though it is accepted in game.
            else if (player.wallet.cash < (player.iceInventoryRequest * iceCost) && player.iceInventoryRequest != 0)
            {
                Console.WriteLine("You do not have enough money for this.  Please revise your request or enter 0.");
                BuyIce(player);
            }
            else if (player.iceInventoryRequest == 0)
            {

            }

        }

        public void BuySugar(Player player)
        {
            player.GetSugarRequest();

            if (player.wallet.cash > (player.sugarInventoryRequest * sugarCost))
            {
                player.wallet.cash -= (player.sugarInventoryRequest * sugarCost);
            }

            //small bug here.  Console responds that "0" is invalid request even though it is accepted in game.
            else if (player.wallet.cash < (player.sugarInventoryRequest * sugarCost) && player.sugarInventoryRequest != 0)
            {
                Console.WriteLine("You do not have enough money for this.  Please revise your request or enter 0.");
                BuySugar(player);
            }
            else if (player.sugarInventoryRequest == 0)
            {

            }

        }
            
    }
}
