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
        public bool CanEat(Food food)
        {
            if (food.DietNames == ToString())
            {
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            return "Omnivorous";
        }
    }
}