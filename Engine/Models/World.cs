using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
   public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imageNmae)
        {
            Location loc = new Location();
            loc.XCoordinate = xCoordinate;
            loc.YCoordinate = yCoordinate;
            loc.Name = name;
            loc.Description = description;
            loc.ImageName = $"Images/Locations/{imageNmae}";

            _locations.Add(loc);
        }

        public Location LocationAt(int xCoordinate, int ycoordinate)
        {
            foreach (Location loc in _locations)
            {
                if(loc.XCoordinate == xCoordinate && loc.YCoordinate == ycoordinate)
                {
                    return loc;
                }
            }
            return null;
        }
    }
}
