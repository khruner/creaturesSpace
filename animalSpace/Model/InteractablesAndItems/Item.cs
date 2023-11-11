using animalSpace.Interfaces;
using animalSpace.Model.Environments;
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

        public Item(string name, List<IStrategyEffect> listStrategies)
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

        //public Item() { }

        public IStrategyEffect Effect { get => effect; set => effect = value; }


        public void Interact(ICreature creature)
        {
            foreach( var effect in listStrategies)
            {
                effect.AppliedEffect(creature);
            }
        }

        public string getEffectsString()
        {
            string effects = "";

            foreach (var effect in listStrategies)
            {
                effects += effect.ToString() + " ";
            }
            return effects;
        }
        public override string ToString()
        {
            return Name;
        }
        public string getItemData()
        {
            return $"nombre: {name}, efectos: {listStrategies}";
        }

        public List<IEnvironment> CompatibleEnvironments()
        {
            List<IEnvironment> habitats = new List<IEnvironment>() { new Terrestrial(), new Aerial(), new Aquatic() };
            return habitats;
        }

    }
}
