using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame2._0
{
    class MainMenu
    {
        public MainMenu()
        {

        }

        public static void mainMenu(string userInput)
        {
            UserInterface.PublicUI();
            Console.WriteLine("You are on planet {0}! Current year is {1}!", 0, 0);
            Console.WriteLine();
            Console.WriteLine("What would you like to do?: \n" +
                "- 'Ship'to buy a new ship\n" +
                "- 'Buy' to buy goods\n" +
                "- 'Sell' to sell goods\n" +
                "- 'travel' to leave and go to the next planet!\n" +
                "- 'inv' to check your current inventory space\n" +
                "- 'exit' to exit the game........");
            userInput = Console.ReadLine();

            // Planetary options
            if ((userInput != "exit") || (userInput != "Exit"))
            {
                if ((userInput == "Ship") || (userInput == "ship"))
                {
                    //Upgrade.ShipMenu();
                }
                else if ((userInput == "Buy") || (userInput == "buy"))
                {
                    Cargo.BuyMenu();
                }
                else if ((userInput == "Sell") || (userInput == "sell"))
                {
                    //Sell.SellMenu();
                }
                else if ((userInput == "Inv") || (userInput == "inv"))
                {
                    //Inventory(maxInventory, curInventory);
                }
                else if ((userInput == "Travel") || (userInput == "travel"))
                {
                    //Travel.TravelMenu();
                }
                else if (userInput == "exit")
                {
                    
                }
            }
        }

    }
}
