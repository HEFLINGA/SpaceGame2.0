using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame2._0
{
    class Program
    {
        public static string userInput;
        public static int credits = 10000;
        

        static void Main(string[] args)
        {
            Story.Intro();
            MainMenu.mainMenu(userInput);
        }
    }
}
