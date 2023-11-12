using animalSpace.Interfaces;
using animalSpace.Model.InteractablesAndItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model.Diets
{
    internal class OmnivorousDiet : IDiet
    {
        
        public bool CanEat(IInteractable food)
        {
            return food is Creature;
        }

        public override string ToString()
        {
            return "Omnivorous";
        }
    }
}