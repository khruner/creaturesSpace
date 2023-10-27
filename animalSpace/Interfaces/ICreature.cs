using animalSpace.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Interfaces
{
    internal interface ICreature
    {
        void MoveThrough(ITerrain terrain);
        int Eat(IInteractable food);
        int Rest();
        int Attack(Creature creature);
        int BeingAttacked(int atkPoints);
        void Interact (IInteractable interact);
        bool Die();
    }
}
