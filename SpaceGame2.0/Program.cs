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
        private static bool gameOver = false;

        static void Main(string[] args)
        {

            Story.Intro();
            do
            {
                MainMenu.Menu(userInput);
            } while (gameOver == false);
        }
    }
}
