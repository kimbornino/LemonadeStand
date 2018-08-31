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
        //methods 
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();

        }
        public /*double*/ void SetPrice()
        {

        }

        public void GetSuppliesRequest()
        {
            GetLemonRequest();
            GetSugarRequest();
            GetIceRequest();
        }

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

            for (int i = 0; i <= pitcherRequest;)
            {
                inventory.lemons -= 2;
                inventory.bagsOfIce -= 2;
                inventory.cupsOfSugar -= 2;
                i++;
            }

        }
        public void SetLemonadePrice()
        {
            Console.WriteLine("How much would you like to charge for your lemonade today?  Please type an amount.");
            lemonadePrice = double.Parse(Console.ReadLine());
        }
           
     }
 
}
