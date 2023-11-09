using animalSpace.Interfaces;
using animalSpace.Model.Kingdoms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model.Environments
{
    internal class Aerial : IEnvironment
    {
        public override string ToString()
        {
            return "Aerial";
        }

        public override bool Equals(object obj)
        {
            if (obj is Aerial)
            {
                return true;
            }
            return false;
        }

        public bool canMoveThroughTheTerrain(ITerrain terrain)
        {
            throw new NotImplementedException();
        }
    }
}
