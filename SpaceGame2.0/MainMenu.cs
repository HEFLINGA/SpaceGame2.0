using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame2._0
{
    class MainMenu
    {
        // TODO - Add time to Gameover
        private static bool GameOver(int credits)
        {
            bool gameOver = false;
            if (credits <= 0)
            {
                gameOver = true;
            }
            else
            {
                gameOver = false;
            }

            return gameOver;
        }

        public MainMenu()
        {

        }

        Planet earth         = new Planet("Earth", 1, 0, 0, 0, 0);
        Planet alphaCentauri = new Planet("Alpha Centauri", 2, 0, 4.367, 0, 4.367);
        Planet trappist      = new Planet("TRAPPIST-1", 3, -3, 7, -3, 7);

        public static void Menu(string userInput)
        {
            do
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
                        Cargo.SellMenu();
                    }
                    else if ((userInput == "Inv") || (userInput == "inv"))
                    {
                        Cargo.InventoryUI(Cargo.maxInventory, Cargo.inventory);
                    }
                    else if ((userInput == "Travel") || (userInput == "travel"))
                    {
                        //Travel.TravelMenu();
                    }
                    else if (userInput == "exit")
                    {

                    }
                }
            } while ((GameOver(Cargo.credits) == false) && (userInput != "exit"));
            // Game over
            //TODO - Add time to game over writeline
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Game Over!! Total play time: {0}.  Total credits earned: {1}.", 0, Cargo.totalCredits - 10000);
            Console.ReadLine();
        }

    }
}
