﻿using animalSpace.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model.InteractablesAndItems.ItemStrategies
{
    internal class ReduceDefense : IStrategyEffect
    {
        public override string ToString()
        {
            return "Reduce Defense";
        }
        public void AppliedEffect(ICreature creature)
        {
            

        }
    }
}