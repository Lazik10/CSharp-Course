using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Location
    {
        private string name;
        private string description;
        private Location west;
        private Location east;
        private Location north;
        private Location south;

        public Location() 
        {
            name = "unknown";
            description = "unknown";
        }
        public Location(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n", name, description);
        }

        public void SetNeighbourField(string direction, Location location)
        {
            switch (direction)
            {
                case "sever":
                    north = location;
                    break;
                case "jih":
                    south = location;
                    break;
                case "vychod":
                    east = location;
                    break;
                case "západ":
                    west = location;
                    break;
                default:
                    break;
            }
        }

        public string GetPossibleMoves()
        {
            string directions = "Můžeš jít na ";
            if (north != null)
                directions += "sever ";
            if (south != null)
                directions += "jih ";
            if (east != null)
                directions += "vychod ";
            if (west != null)
                directions += "západ";
            return directions + "\n";
        }

        public Location GetCorrectLocation(string direction)
        {
            Location location = new Location();

            switch (direction)
            {
                case "sever":
                    location = north;
                    break;
                case "jih":
                    location = south;
                    break;
                case "vychod":
                    location = east;
                    break;
                case "západ":
                    location = west;
                    break;
                default:
                    break;
            }

            return location;
        }
    }
}
