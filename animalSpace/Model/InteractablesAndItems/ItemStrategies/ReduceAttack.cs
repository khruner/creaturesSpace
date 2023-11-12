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
    internal class ReduceAttack : IStrategyEffect
    {
        public override string ToString()
        {
            return "Reduce Attack";
        }
        public void AppliedEffect(Creature creature)
        {
            creature.AttackPoints -= Dice.ThrowDice(15);
            MessageBox.Show("Se redujo el ataque correctamente");
        }
    }
}
