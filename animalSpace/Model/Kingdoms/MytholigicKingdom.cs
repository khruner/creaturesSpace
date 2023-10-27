using animalSpace.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace animalSpace.Model.Kingdoms
{
    internal class MytholigicKingdom: IKingdom
    {
        public override string ToString()
        {
            return "Mythologic";
        }
        public override bool Equals(object obj)
        {
            if (obj is MytholigicKingdom)
            {
                return true;
            }
            return false;
        }
    }
}
