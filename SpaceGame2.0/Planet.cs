using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame2._0
{
    class Planet
    {
        private string name;
        private int planet;
        private double x;
        private double y;
        private double destX;
        private double destY;

        public Planet()
        {

        }

        public Planet(string name, int planet, double x, double y, double destX, double destY)
        {
            this.name = name;
            this.planet = planet;
            this.x = x;
            this.y = y;
            this.destX = destX;
            this.destY = destY;
        }

    }
}
