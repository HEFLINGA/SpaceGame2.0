using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame2._0
{
    class Cargo
    {
        // cost of different cargo
        private static int costFood = 2000;
        private static int costResearch = 3000;
        private static int costAnimals = 4000;
        private static int costWater = 5000;
        private static int costDarkMatter = 6000;

        // inventory space
        private static int invFood = 0;
        private static int invResearch = 0;
        private static int invAnimals = 0;
        private static int invWater = 0;
        private static int invDarkMatter = 0;
        private static int remInventory = 0;
        public static int inventory = 0;
        public static int maxInventory = 3;

        public static int Inventory(int maxInventory, int inventory)
        {
            // remaining inventory space
            remInventory = maxInventory - inventory;
            if (inventory > 0)
            {
                Console.WriteLine("You have {0} Food", invFood);
                Console.WriteLine("You have {0} Research", invResearch);
                Console.WriteLine("You have {0} Animals", invAnimals);
                Console.WriteLine("You have {0} Water", invWater);
                Console.WriteLine("You have {0} Fuel", invDarkMatter);
                Console.WriteLine("You have {0} out of {1} spaces remaining", remInventory, maxInventory);
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
            else if (inventory == 0)
            {
                Console.WriteLine("Your inventory is empty!");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }

            return inventory;
        }

        private static int Buy(int inventory, int maxInventory, int credits, int costItem, int invItem)
        {
            if ((inventory < maxInventory) && (credits >= costItem))
            {
                credits -= costItem;
                invItem += invItem;
            }
            else if (credits <= costItem)
            {
                UserInterface.PublicUI();
                Console.WriteLine("You do not have enough Credits to purchase item!");
                Console.WriteLine("Press 'Enter' to return to Menu");
                Console.ReadLine();
            }
            else if ((remInventory < invItem) || (inventory == maxInventory))
            {
                UserInterface.PublicUI();
                Console.WriteLine("You do not have enough space in your inventory!");
                Console.WriteLine("Press 'Enter' to return to Menu");
                Console.ReadLine();
            }

            return invItem;
        }        

        public static void BuyMenu()
        {
            string buyInput = "";

            do
            {
                UserInterface.PublicUI();

                Console.WriteLine("What would you like to buy?: \n" +
                                    "(Type name of Item to purchase)");
                Console.WriteLine("press 'Enter' to leave the trading post");
                Console.WriteLine();
                Console.WriteLine($"Food, price:        {costFood}. This will take up 1 cargo slot");
                Console.WriteLine($"Research, price:    {costResearch}. This will take up 1 cargo slot");
                Console.WriteLine($"Animals, price:     {costAnimals}. This will take up 1 cargo slot");
                Console.WriteLine($"Water, price:       {costWater}. This will take up 2 cargo slots");
                Console.WriteLine($"Dark Matter, price: {costDarkMatter}. This will take up 5 cargo slots");

                buyInput = Console.ReadLine();
                switch (buyInput)
                {
                    case "Food":
                    case "food":
                        Console.Clear();
                        Buy(inventory, maxInventory, Program.credits, costFood, invFood);
                        UserInterface.PublicUI();
                        break;
                    case "Research":
                    case "research":
                        Console.Clear();
                        Buy(inventory, maxInventory, Program.credits, costResearch, invResearch);
                        UserInterface.PublicUI();
                        break;
                    case "animals":
                    case "Animals":
                        Console.Clear();
                        Buy(inventory, maxInventory, Program.credits, costAnimals, invAnimals);
                        UserInterface.PublicUI();
                        break;
                    case "water":
                    case "Water":
                        Console.Clear();
                        Buy(inventory, maxInventory, Program.credits, costWater, invWater);
                        UserInterface.PublicUI();
                        break;
                    case "fuel":
                    case "Fuel":
                        Console.Clear();
                        Buy(inventory, maxInventory, Program.credits, costDarkMatter, invDarkMatter);
                        UserInterface.PublicUI();
                        break;
                    case "":
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
            } while (buyInput != "");
        }

    }
}
