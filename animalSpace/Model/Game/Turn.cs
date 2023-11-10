using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model.Game
{
    internal class Turn
    {
        protected Player player { get; set; }
        protected string description { get; set; }
        public Turn(Player playerInTurn, string desc) 
        {
            player = playerInTurn;
            description = desc;
        }
        public string ToString()
        {
            return $"El jugador {player.getName()}, {description} ";
        }
    }
}
