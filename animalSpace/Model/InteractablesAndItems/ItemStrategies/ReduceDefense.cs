using animalSpace.Interfaces;
using animalSpace.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animalSpace.Model.InteractablesAndItems.ItemStrategies
{
    internal class ReduceDefense : IStrategyEffect
    {
        public override string ToString()
        {
            return "Reduce Defense";
        }
        public void AppliedEffect(Creature creature)
        {
            creature.DefPoints -= Dice.ThrowDice(15);
            MessageBox.Show("Se redujo la defensa correctamente");
        }
    }
}
