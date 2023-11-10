using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model.Game
{
    internal class Player
    {
        protected string name;
        protected double score;
        protected List<Creature> listOfCreatures { get; set; }
        public Player(string Name)
        {
            name = Name;
            score = 0;
            listOfCreatures = new List<Creature>();
        }

        public string getName()
        {
            return name;
        }
    }
}
