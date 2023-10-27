using animalSpace.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model.InteractablesAndItems
{
    internal class Item : IInteractable
    {
        protected static int counterID = 0;
        protected int ID;
        protected string Name;
        IStrategyEffect effect;

        public void Interact(ICreature creature)
        {
            throw new NotImplementedException();
        }
    }
}
