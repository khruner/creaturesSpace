using animalSpace.Controllers;
using animalSpace.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model
{
    internal class Map
    {
        private static int ContID = 0;
        public int Id { get; private set; }
        List<ITerrain> terrains;
        List<Creature> creatures;

        public List<ITerrain> Terrains { get => terrains; set => terrains = value; }
        public List<Creature> Creatures { get => creatures; set => creatures = value; }

        public Map(int id, List<ITerrain> terrenos, List<Creature> criaturas)
        {
            Id = ContID++;
            Terrains = terrenos;
            Creatures = criaturas;
        }
        public List<ITerrain> GenerarMapaAleatorio(int cantidadTerrenos)
        {
            List<ITerrain> todosLosTerrenos = ControllerTerrain.GetInstance().GetAllTerrenos();
            Random random = new Random();
            List<ITerrain> terrenosAleatorios = new List<ITerrain>();

            for (int i = 0; i < cantidadTerrenos; i++)
            {
                int indiceAleatorio = random.Next(todosLosTerrenos.Count);
                terrenosAleatorios.Add(todosLosTerrenos[indiceAleatorio]);
            }

            return terrenosAleatorios;
        }
    }
}
