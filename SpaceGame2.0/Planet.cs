using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame2._0
{
    public class Planet
    {
        public string name;
        public int planet;
        public double x;
        public double y;
        public double destX;
        public double destY;

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
