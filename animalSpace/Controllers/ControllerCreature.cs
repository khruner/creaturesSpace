using animalSpace.Interfaces;
using animalSpace.Model;
using animalSpace.Model.Diets;
using animalSpace.Model.Environments;
using animalSpace.Model.InteractablesAndItems;
using animalSpace.Model.Kingdoms;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public List<Creature> loadPreDefinedCreaturesTest1() 
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
            listCreatures.AddRange(creaturesList);
            return listCreatures;
        }
        public List<Creature> loadPreDefinedCreaturesTest2()
        {
            List<IEnvironment> environments = new List<IEnvironment>() { new Terrestrial(), new Aquatic() };
            List<Creature> creaturesList = new List<Creature>
            {
                new Creature("Perro", new CarnivorousDiet(), new AnimalKingdom(), environments),
                new Creature("Lagarto", new CarnivorousDiet(), new MachineKingdom(), environments),
                new Creature("Fenix", new CarnivorousDiet(), new MytholigicKingdom(), environments),
                new Creature("Cienpiés", new OmnivorousDiet(), new AnimalKingdom(), environments),
                new Creature("Mantis", new HerviborousDiet(), new AnimalKingdom(), environments),
            };
            return creaturesList;
        }
        public List<Creature> getCreatures()
        {
            return listCreatures;
        }

        public void AttackCreature(Creature creatureAttaking, Creature attackedCreature) 
        {
            try
            {
                creatureAttaking.Attack(attackedCreature);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        public void Eat (Creature creature, IInteractable food) 
        {
            creature.Eat(food);
        }

        public void useItem(Creature creature, IInteractable item)
        {
            item.Interact(creature);
        }
    }
}
