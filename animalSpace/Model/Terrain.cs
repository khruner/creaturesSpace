using animalSpace.Interfaces;
using animalSpace.Model.InteractablesAndItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace animalSpace.Model
{
    internal class Terrain
    {
        protected static int counterID = 0;
        protected int ID;
        protected ITerrain terrainType;
        /*protected List<Terrain> borderingTerrain = new List<Terrain>();
        protected List<IPositionable> positionables;//items dentro del terreno
        protected List<Item> items = new List<Item>();
        protected List<Food> foods = new List<Food>();
        protected List<Creature> creatures = new List<Creature>();*/
        public List<IInteractable> interactables;

        public ITerrain TerrainType { get => terrainType; set => terrainType = value; }
        public List<IInteractable> Interactables { get => interactables; set => interactables = value; }

        public Terrain(ITerrain terrainType, List<IInteractable> interactables)
        {
            ID = counterID;
            counterID++;
            TerrainType = terrainType;
            Interactables = interactables;

        }
        public override string ToString()
        {
            return $"{terrainType}";
        }
    }
}
