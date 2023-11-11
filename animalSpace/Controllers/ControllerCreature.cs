using animalSpace.Interfaces;
using animalSpace.Model;
using animalSpace.Model.Diets;
using animalSpace.Model.Environments;
using animalSpace.Model.Kingdoms;
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

        public void createCreature(string Name, IDiet Diet, IKingdom Kingdom, List<IEnvironment> Environment)
        {
            listCreatures.Add(new Creature(Name, Diet, Kingdom, Environment));
        }

        public List<Creature> loadPreDefinedCreatures() 
        {
            List<IEnvironment> environments = new List<IEnvironment>() { new Terrestrial(), new Aquatic()};
            List<Creature> creaturesList = new List<Creature>
            {
                new Creature("Lobo", new CarnivorousDiet(), new AnimalKingdom(), environments),
                new Creature("Godzilla", new CarnivorousDiet(), new MachineKingdom(), environments),
                new Creature("Fenrir", new CarnivorousDiet(), new MytholigicKingdom(), environments),
                new Creature("Koala", new OmnivorousDiet(), new AnimalKingdom(), environments),
                new Creature("Mono", new HerviborousDiet(), new AnimalKingdom(), environments),
            };
            return creaturesList;
        }
        public List<Creature> getCreatures()
        {
            return listCreatures;
        }

    }
}
