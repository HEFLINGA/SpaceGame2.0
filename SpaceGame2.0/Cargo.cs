using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame2._0
{
    class Cargo
    {
        // credits
        public static int credits = 10000;
        public static int totalCredits = 0;
        // cost of different cargo
        private static int costFood = 2000;
        private static int costResearch = 3000;
        private static int costAnimals = 4000;
        private static int costWater = 5000;
        private static int costDarkMatter = 15000;

        // inventory space
        private static int invFood = 0;
        private static int invResearch = 0;
        private static int invAnimals = 0;
        private static int invWater = 0;
        private static int invDarkMatter = 0;
        private static int remInventory = maxInventory - inventory;
        public static int inventory = 0;
        public static int maxInventory = 3;

        private static int CreditsBuy(int costItem)
        {
            credits -= costItem;
            return credits;
        }

        private static int CreditsSell(int costItem)
        {
            credits += costItem;
            return credits;
        }

        private static int InventoryAdd(int invItem)
        {
            if (invItem == invFood)
            {
                invFood += 1;
            }
            else if (invItem == invResearch)
            {
                invResearch += 1;
            }
            else if (invItem == invAnimals)
            {
                invAnimals += 1;
            }
            else if (invItem == invWater)
            {
                invWater += 2;
            }
            else if (invItem == invDarkMatter)
            {
                invDarkMatter += 5;
            }

            return invItem;
        }

        private static int InventorySub(int invItem)
        {
            if (invItem == invFood)
            {
                invFood -= 1;
            }
            else if (invItem == invResearch)
            {
                invResearch -= 1;
            }
            else if (invItem == invAnimals)
            {
                invAnimals -= 1;
            }
            else if (invItem == invWater)
            {
                invWater -= 2;
            }
            else if (invItem == invDarkMatter)
            {
                invDarkMatter -= 5;
            }

            return invItem;
        }

        private static int InventoryTotal(int invFood, int invResearch, int invAnimals, int invWater, int invDarkMatter)
        {
            inventory = invFood + invResearch + invAnimals + invWater + invDarkMatter;           
            return inventory;
        }

        public static int InventoryUI(int maxInventory, int inventory)
        {
            // remaining inventory space
            remInventory = maxInventory - inventory;
            InventoryTotal(invFood, invResearch, invAnimals, invWater, invDarkMatter);

            Console.WriteLine("You have {0} Food", invFood);
            Console.WriteLine("You have {0} Research", invResearch);
            Console.WriteLine("You have {0} Animals", invAnimals);
            Console.WriteLine("You have {0} Water", invWater);
            Console.WriteLine("You have {0} Fuel", invDarkMatter);
            Console.WriteLine("You have {0} out of {1} spaces remaining", remInventory, maxInventory);
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();

            return remInventory;
        }

        private static int Buy(int inventory, int maxInventory, int credits, int costItem, int invItem)
        {
            if ((invItem < maxInventory) && (credits >= costItem))
            {
                CreditsBuy(costItem);
                InventoryAdd(invItem);
            }
            else if (credits < costItem)
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
                InventoryTotal(invFood, invResearch, invAnimals, invWater, invDarkMatter);
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
                        Buy(inventory, maxInventory, credits, costFood, invFood);
                        InventoryTotal(invFood, invResearch, invAnimals, invWater, invDarkMatter);
                        UserInterface.PublicUI();
                        break;
                    case "Research":
                    case "research":
                        Console.Clear();
                        Buy(inventory, maxInventory, credits, costResearch, invResearch);
                        InventoryTotal(invFood, invResearch, invAnimals, invWater, invDarkMatter);
                        UserInterface.PublicUI();
                        break;
                    case "animals":
                    case "Animals":
                        Console.Clear();
                        Buy(inventory, maxInventory, credits, costAnimals, invAnimals);
                        InventoryTotal(invFood, invResearch, invAnimals, invWater, invDarkMatter);
                        UserInterface.PublicUI();
                        break;
                    case "water":
                    case "Water":
                        Console.Clear();
                        Buy(inventory, maxInventory, credits, costWater, invWater);
                        InventoryTotal(invFood, invResearch, invAnimals, invWater, invDarkMatter);
                        UserInterface.PublicUI();
                        break;
                    case "Dark Matter":
                    case "dark matter":
                        Console.Clear();
                        Buy(inventory, maxInventory, credits, costDarkMatter, invDarkMatter);
                        InventoryTotal(invFood, invResearch, invAnimals, invWater, invDarkMatter);
                        UserInterface.PublicUI();
                        break;
                    case "":
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }

            }
            }

        public static int Sell(int inventory, int maxInventory, int credits, int costItem, int invItem)
        {
            if (invItem >= 1)
            {
                CreditsSell(costItem);
                totalCredits += costItem;
                InventorySub(invItem);
            }
            else if (invItem == 0)
            {
                UserInterface.PublicUI();
                Console.WriteLine("You do not have any Food in your inventory to sell!");
                Console.WriteLine("Press 'Enter' to return to Menu");
                Console.ReadLine();
            }

            return invItem;
        }        

        public static void SellMenu()
        {
            string sellInput = "";

            do
            {                
                InventoryTotal(invFood, invResearch, invAnimals, invWater, invDarkMatter);
                UserInterface.PublicUI();

                Console.WriteLine("What would you like to Sell?: \n" +
                                    "(Type name of Item to purchase)");
                Console.WriteLine("press 'Enter' to leave the trading post");
                Console.WriteLine();
                Console.WriteLine($"Food, sale price:     {costFood}");
                Console.WriteLine($"Research, sale price: {costResearch}");
                Console.WriteLine($"Animals, sale price:  {costAnimals}");
                Console.WriteLine($"Water, sale price:    {costWater}");
                Console.WriteLine($"Fuel, sale price:     {costDarkMatter}");

                sellInput = Console.ReadLine();
                switch (sellInput)
                {
                    case "Food":
                    case "food":
                        Console.Clear();
                        Sell(inventory, maxInventory, credits, costFood, invFood);
                        InventoryTotal(invFood, invResearch, invAnimals, invWater, invDarkMatter);
                        UserInterface.PublicUI();
                        break;
                    case "Research":
                    case "research":
                        Console.Clear();
                        Sell(inventory, maxInventory, credits, costResearch, invResearch);
                        InventoryTotal(invFood, invResearch, invAnimals, invWater, invDarkMatter);
                        UserInterface.PublicUI();
                        break;
                    case "animals":
                    case "Animals":
                        Console.Clear();
                        Sell(inventory, maxInventory, credits, costAnimals, invAnimals);
                        InventoryTotal(invFood, invResearch, invAnimals, invWater, invDarkMatter);
                        UserInterface.PublicUI();
                        break;
                    case "water":
                    case "Water":
                        Console.Clear();
                        Sell(inventory, maxInventory, credits, costWater, invWater);
                        InventoryTotal(invFood, invResearch, invAnimals, invWater, invDarkMatter);
                        UserInterface.PublicUI();
                        break;
                    case "Dark Matter":
                    case "dark matter":
                        Console.Clear();
                        Sell(inventory, maxInventory, credits, costDarkMatter, invDarkMatter);
                        InventoryTotal(invFood, invResearch, invAnimals, invWater, invDarkMatter);
                        UserInterface.PublicUI();
                        break;
                    case "":
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;

                }
            } while (sellInput != "");
        }
    }

}

