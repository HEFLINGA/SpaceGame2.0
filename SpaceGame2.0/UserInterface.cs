using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame2._0
{
    class UserInterface
    {
        // TODO - Change values of UI to actually take real values
        private static void UI(int inventory, int maxInventory, string character, int credits, double time)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(30, 1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Cargo: {0}/{1}", inventory, maxInventory);
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
            UI(Cargo.inventory, Cargo.maxInventory, Story.character, Cargo.credits, 0);
        }
    }
}
