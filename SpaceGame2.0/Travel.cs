using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame2._0
{
    class Travel
    {
        private static int currentLocation = 0;
        private static int earth = 1;
        private static int alphaCentauri = 2;
        private static int trappist = 3;
        private static int krootabulon = 4;

        // creating planet objects
        public static Planet currentPlanet = new Planet("", 0, 0, 0, 0, 0);

        // Code for Planets
        public static int PlanetaryTravel()
        {
            if (currentLocation == earth)
            {
                currentPlanet.name  = "Earth";
                currentPlanet.x     = 0;
                currentPlanet.y     = 0;
            }
            else if (currentLocation == alphaCentauri)
            {
                currentPlanet.name  = "Alpha Centauri";
                currentPlanet.x     = 0;
                currentPlanet.y     = 4.367;
            }
            else if (currentLocation == trappist)
            {
                currentPlanet.name = "TRAPPIST-1";
                currentPlanet.x = -2;
                currentPlanet.y = 6;
            }
            else if (currentLocation == krootabulon)
            {
                currentPlanet.name = "Krootabulon!";
                currentPlanet.x = 3;
                currentPlanet.y = -7;
            }

            return currentLocation;
        }

        // Code to check your planet
        public static int Earth()
        {

            UserInterface.PublicUI();
            if (currentPlanet == earth)
            {
                Console.WriteLine("You are already here!! No need to travel anywhere..");
                Console.WriteLine("Press 'enter' to return to Menu");
                Console.ReadLine();
            }
            else if (currentPlanet != earth)
            {
                destX = 0;
                destY = 0;
                Console.WriteLine("Heading to Earth!");
                Console.WriteLine("Distance is: {0}LYs", Math.Round(Distance(x, y, destX, destY), 3));
                Console.WriteLine("It will take you: {0}yrs", timePassage = Math.Round(Distance(x, y, destX, destY) / Velocity(speed), 2));
                Console.WriteLine();
                Console.WriteLine("type 'GO' to depart");
                Console.WriteLine("press 'enter' to go back to main menu");
                string conf = Console.ReadLine();

                if (conf == "GO")
                {
                    currentPlanet = earth;
                    time += timePassage;
                    Planet(earth, alphaCentauri, trappist, krootabulon);
                }
                else
                {
                    Console.WriteLine("Returning to Menu");
                    System.Threading.Thread.Sleep(1100);
                }

            }

            return currentPlanet;
        }
    }
}
