using animalSpace.Interfaces;
using animalSpace.Model;
using animalSpace.Model.InteractablesAndItems;
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

        public List<Item> getItems()
        {
            return listItems;
        }
    }
}
