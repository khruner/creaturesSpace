using animalSpace.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model.Environments
{
    internal class Aquatic
    {
        public override string ToString()
        {
            return "Aquatic";
        }

        public override bool Equals(object obj)
        {
            if (obj is Aquatic)
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
