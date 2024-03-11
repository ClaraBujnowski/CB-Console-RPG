using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Location
    {
        public string name;
        public string description;
        public Battle battle;

        public Location north, east, south, west;

        public Location(string name, string description, Battle battle = null)
        {
            this.name = name;
            this.description = description;
            this.battle = battle;
        }

        public void SetNearbyLocations(Location north, Location east, Location south, Location west)
        {
            this.north = north;
            this.east = east;
            this.south = south;
            this.west = west;

            if (!(north is null))
                this.north = north;
                north.south = this;

            if(!(east is null))
                this.east = east;
                east.west = this;

            if (!(south is null))
                this.south = south;
                south.north = this;

            if (!(west is null))
                this.west = west;
                west.east = this;
        }

        public void Resolve(List<Player> players)
        {
            Console.WriteLine("You find yourself in " + this.name + ".");
            Console.WriteLine(this.description);

            if(!(north is null))
                Console.WriteLine("NORTH" + this.north.name);

            if (!(east is null))
                Console.WriteLine("EAST" + this.east.name);

            if (!(south is null))
                Console.WriteLine("SOUTH" + this.south.name);

            if (!(west is null))
                Console.WriteLine("WEST" + this.west.name);

            string direction = Console.ReadLine();
            Location nextLocation = null;

            if (direction == "north")
                nextLocation = this.north;
            else if (direction == "east")
                nextLocation = this.east;
            else if (direction == "south")
                nextLocation = this.south;
            else if (direction == "west")
                nextLocation = this.west;

            nextLocation.Resolve(players);
        }
    }
}
