using animalSpace.Interfaces;
using animalSpace.Model;
using animalSpace.Model.Diets;
using animalSpace.Model.Environments;
using animalSpace.Model.InteractablesAndItems;
using animalSpace.Model.InteractablesAndItems.ItemStrategies;
using animalSpace.Model.Kingdoms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Controllers
{
    internal class ControllerItem
    {
        private static ControllerItem Instance;

        List<Item> listItems = new List<Item>();

        public static ControllerItem getInstance()
        {
            if (Instance == null)
            {
                Instance = new ControllerItem();
            }
            return Instance;
        }

        public void createItem(string Name, List<IStrategyEffect> Effect)
        {
            listItems.Add(new Item(Name, Effect));
        }
        private List<Item> generatePredefinedItems()
        {
            List<IStrategyEffect> AtkPlusDefRed = new List<IStrategyEffect>() { new IncreaseAttack(), new ReduceDefense() };
            List<IStrategyEffect> DefPlusAtkRed = new List<IStrategyEffect>() { new IncreaseDefense(), new ReduceAttack() };
            List<Item> creaturesList = new List<Item>
            {
                new Item(new IncreaseAttack(), "Pocion de ataque"),
                new Item("Suba de Ataque, pero resta de defensa", AtkPlusDefRed),
                new Item("Suba de Defensa, pero resta de Ataque", DefPlusAtkRed)
            };
            return creaturesList;
        }
        public List<Item> getItems()
        {
            return listItems;
        }
    }
}
