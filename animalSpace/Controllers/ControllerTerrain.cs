using animalSpace.Interfaces;
using animalSpace.Model.Terrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Controllers
{
    internal class ControllerTerrain
    {
        static ControllerTerrain Instance;
        public static ControllerTerrain GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ControllerTerrain();
            }
            return Instance;
        }
        public List<ITerrain> GetAllTerrenos()
        {
            List<ITerrain> listaTerrenos = new List<ITerrain>
            {
                new Air(),
                new Earth(),
                new Water()
            };
            return listaTerrenos;
        }
    }
}
