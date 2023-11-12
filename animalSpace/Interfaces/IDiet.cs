using animalSpace.Model;
using animalSpace.Model.InteractablesAndItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Interfaces
{
    internal interface IDiet
    {
        bool CanEat(IInteractable food);
    }
}
