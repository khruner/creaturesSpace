using animalSpace.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model.InteractablesAndItems
{
    internal class Item : IInteractable
    {
        protected static int counterID = 0;
        protected int ID { get; private set; }
        protected string name;
        IStrategyEffect effect;
        List<IStrategyEffect> listStrategies;

        public string Name 
        { 
            get => name;
            set => name = value;
        
        }
        internal List<IStrategyEffect> ListStrategies 
        { 
            get => listStrategies;

            set => listStrategies = value;
        }

        public string StrategyNames
        {
            get
            {
                string effectsListString = "";
                foreach (var e in listStrategies)
                {
                    effectsListString = string.Join(", ", listStrategies);
                }
                return effectsListString;
            }
        }

        public Item(List<IStrategyEffect> listStrategies, string name)
        {
            counterID++;
            ID = counterID;
            ListStrategies = listStrategies;
            Name = name;
        }
        public Item(IStrategyEffect effec, string name)
        {
            counterID++;
            ID = counterID;
            Effect = effect;
            Name = name;
        }

        public Item() { }

        public IStrategyEffect Effect { get => effect; set => effect = value; }


        public void Interact(ICreature creature)
        {
            foreach( var effect in listStrategies)
            {
                effect.AppliedEffect(creature);
            }
        }

        public override string ToString()
        {
            return Name;
        }


    }
}
