using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //memmber variables
        public string rules;
        public Player player;
        //public UserInterface
        public Weather forecast;
        public Weather actualWeather;

        //methods
        //public UserInterface.DisplayRules()
       // {

        //}
        //Weather.DisplayForecast();
        //DisplayInventory();
        //GetsUserInput
        //GetActualForecast
        //playDay
        //TotalProfits
        //DisplayProfits
        //DecideToDoNextRound

        public void RunGame()
        {
            // CAN i ACTUALLY USE var HERE?
            var rules = new UserInterface();
            rules.DisplayRules();
            
        }
    }
}
