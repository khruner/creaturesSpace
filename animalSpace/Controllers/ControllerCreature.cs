using animalSpace.Interfaces;
using animalSpace.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Controllers
{
    internal class ControllerCreature
    {
        private static ControllerCreature Instance;

        List<Creature> listCreatures = new List<Creature>();

        public static ControllerCreature getInstance()
        {
            if (Instance == null){
                Instance = new ControllerCreature();
            }
            return Instance;
        }

        public void createCreature(string Name, IDiet Diet, IKingdom Kingdom, string Environment)
        {
            listCreatures.Add(new Creature(Name, Diet, Kingdom, Environment));
        }

        public List<Creature> getCreatures()
        {
            return listCreatures;
        }

    }
}
