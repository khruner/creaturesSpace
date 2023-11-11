using animalSpace.Interfaces;
using animalSpace.Model.Environments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model.Terrains
{
    internal class Water : ITerrain
    {
        private List<IEnvironment> compatibleEnvironments = new List<IEnvironment>() { new Aquatic(), new Aerial() };
        public override string ToString()
        {
            return "Water";
        }
    }
}
