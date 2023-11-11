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
        protected List<Terrain> borderingTerrain = new List<Terrain>();
        protected List<IPositionable> positionables;//items dentro del terreno
        protected List<Item> items = new List<Item>();
        protected List<Food> foods = new List<Food>();
        protected List<Creature> creatures = new List<Creature>();
        

        public Terrain(ITerrain TerrainType)
        {
            ID = counterID;
            counterID++;
            TerrainType = terrainType;
            positionables = new List<IPositionable>();
        }
        public override string ToString()
        {
            return $"{terrainType}";
        }
    }
}
