using animalSpace.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Interfaces
{
    internal interface IStrategyEffect
    {
        void AppliedEffect(Creature creature);
    }
}
