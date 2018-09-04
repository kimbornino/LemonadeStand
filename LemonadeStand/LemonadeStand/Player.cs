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


        public int GetLemonRequest()
        {
            Console.WriteLine(" \n How many lemons would you like?");
            //lemonInventoryRequest = int.Parse(Console.ReadLine());
            try
            {
                lemonInventoryRequest = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number");
                GetLemonRequest();
            }
            return lemonInventoryRequest;

        }
        public int GetSugarRequest()
        {
            Console.WriteLine("How many cups of sugar would you like?");
            try
            {
                sugarInventoryRequest = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                GetSugarRequest();
            }
            return sugarInventoryRequest;
        }
        public int GetIceRequest()
        {
            Console.WriteLine("How many bags of ice would you like?");
            try
            {
                iceInventoryRequest = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                GetIceRequest();
            }

            return iceInventoryRequest;
        }
        public void MakeLemonade()
        {
            {
                Console.WriteLine("\n How many pitchers would you like to prepare?");
                try
                {
                    pitcherRequest = int.Parse(Console.ReadLine());
                }
                catch (FormatException)

                {
                    Console.WriteLine("Please enter a valid whole number");
                }
            }

            if (inventory.lemons >= (pitcherRequest * 2) && inventory.bagsOfIce >= (pitcherRequest * 2) && inventory.cupsOfSugar >= (pitcherRequest * 2))
            {
                for (int i = 1; i <= pitcherRequest;)
                {
                    inventory.lemons -= 2;
                    inventory.bagsOfIce -= 2;
                    inventory.cupsOfSugar -= 2;
                    i++;
                }
                cupsOfLemonade = pitcherRequest * 10;
                Console.WriteLine("You made " + pitcherRequest + " pitchers of lemonade.  So you made " + cupsOfLemonade + " cups of lemonade");
            }
            else
            {
                Console.WriteLine("You do not have enough supplies in your inventory to make that many pitchers.  Please enter a valid number.");
                MakeLemonade();
            }


        }
        public void SetLemonadePrice()
        {
            Console.WriteLine("How much would you like to charge for your lemonade today?  Please type an amount between $0.50 and $2.00.");
            lemonadePrice = double.Parse(Console.ReadLine());
        }

        public void validateLemonadePrice()
        {
            if (lemonadePrice < 2.00 && lemonadePrice > .50)
            {
                Console.WriteLine("You set your lemonade price to $ " + lemonadePrice + " per cup.  Good Luck!");
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
                SetLemonadePrice();
            }
        }
           
     }
 
}
