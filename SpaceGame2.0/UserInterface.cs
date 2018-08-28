﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame2._0
{
    class UserInterface
    {
        // TODO - Change values of UI to actually take real values
        private static void UI(int curInventory, int invFood, int invResearch, int invAnimals, int invWater, int invFuel, int maxInventory, 
            string character, int credits, double time)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(30, 1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Cargo: {0}/{1}", curInventory = invFood + invResearch + invAnimals + invWater + invFuel, maxInventory);
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Name: {0}", character);
            Console.SetCursorPosition(55, 1);
            Console.WriteLine("Credits: {0}", credits);
            Console.SetCursorPosition(90, 1);
            Console.WriteLine("Year: {0}", time);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }

        
        public static void PublicUI()
        {
            UI(0, 0, 0, 0, 0, 0, 3, Story.character, Program.credits, 0);
        }
    }
}
