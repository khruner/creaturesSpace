using animalSpace.Interfaces;
using animalSpace.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model.InteractablesAndItems.ItemStrategies
{
    internal class IncreaseDefense : IStrategyEffect
    {

        public override string ToString()
        {
            return "Increase Defense";
        }
        public void AppliedEffect(Creature creature)
        {
            creature.DefensePoints += Dice.ThrowDice(15);
        }
    }
}
