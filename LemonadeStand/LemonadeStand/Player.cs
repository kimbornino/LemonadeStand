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
        public int sugarINventoryRequest;
        public int iceInventoryRequest;
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
            sugarINventoryRequest = int.Parse(Console.ReadLine());
            return sugarINventoryRequest;
        }
        public int GetIceRequest()
        {
            Console.WriteLine("How many bags of ice would you like?");
            iceInventoryRequest = int.Parse(Console.ReadLine());
            return iceInventoryRequest;
        }
    }
}
