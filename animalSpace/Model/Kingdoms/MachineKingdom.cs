using animalSpace.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace animalSpace.Model.Kingdoms
{
    internal class MachineKingdom : IKingdom
    {
        public override string ToString()
        {
            return "Machine";
        }
        public override bool Equals(object obj)
        {
            if (obj is MachineKingdom)
            {
                return true;
            }
            return false;
        }
    }
}
