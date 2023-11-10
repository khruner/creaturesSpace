using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Static
{
    internal static class Dice
    {
        static Random RandomSide = new Random();
        public static int ThrowDice(int cantidadCaras)
        {
            return RandomSide.Next(1, cantidadCaras);
        }
    }
}
