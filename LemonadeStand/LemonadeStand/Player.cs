using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string playerName;
        public int lemonInventoryRequest;
        public int sugarInventoryRequest;
        public int iceInventoryRequest;
        public int pitcherRequest;
        public double lemonadePrice;
        public Inventory inventory;
        public Wallet wallet;
        public double profits;
        public int cupsOfLemonade;

        //methods 
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();

        }
        public /*double*/ void SetPrice()
        {

        }

        //public void GetSuppliesRequest()
        //{
            //GetLemonRequest();
            //GetSugarRequest();
            //GetIceRequest();
        //}

        public int GetLemonRequest()
        {
            Console.WriteLine(" \n How many lemons would you like?");
            lemonInventoryRequest = int.Parse(Console.ReadLine());
            return lemonInventoryRequest;
            
        }
        public int GetSugarRequest()
        {
            Console.WriteLine("How many cups of sugar would you like?");
            sugarInventoryRequest = int.Parse(Console.ReadLine());
            return sugarInventoryRequest;
        }
        public int GetIceRequest()
        {
            Console.WriteLine("How many bags of ice would you like?");
            iceInventoryRequest = int.Parse(Console.ReadLine());
            return iceInventoryRequest;
        }
        public void MakeLemonade()
        {
            Console.WriteLine("\n How many pitchers would you like to prepare?");
            pitcherRequest = int.Parse(Console.ReadLine());

            if (inventory.lemons >= (pitcherRequest * 2) && inventory.bagsOfIce >= (pitcherRequest * 2) && inventory.cupsOfSugar >= (pitcherRequest * 2))
            {
                for (int i = 1; i <= pitcherRequest;)
                {
                    inventory.lemons -= 2;
                    inventory.bagsOfIce -= 2;
                    inventory.cupsOfSugar -= 2;
                    i++;
                }
            }
            else
            {
                Console.WriteLine("You do not have enough supplies in your inventory to make that many pitchers.  Please enter a valid number.");
                MakeLemonade();
            }
            //new code
            cupsOfLemonade = pitcherRequest * 10;
            Console.WriteLine("You made " + pitcherRequest + " pitchers of lemonade.  So you made " + cupsOfLemonade + " cups of lemonade");
        }
        public void SetLemonadePrice()
        {
            Console.WriteLine("How much would you like to charge for your lemonade today?  Please type an amount.");
            lemonadePrice = double.Parse(Console.ReadLine());
        }
           
     }
 
}
