using animalSpace.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model
{
    internal class Creature : IKingdom//ICreature 
    {
        Random rnd = new Random();
        protected static int counterID = 0;
        protected int ID;
        protected string CreatureName;
        protected int MaxEnergy { get; set; }
        protected int CurrentEnergy { get; set; }
        protected int MaxHealth { get; set; }
        protected int CurrentHealth { get; set; }
        protected int AttackPoints { get; set; }
        protected int DefPoints { get; set; }
        protected int AttackRange { get; set; }
        protected IKingdom Kingdom;
        protected IDiet Diet;
        protected List<IEnvironment> Environment;

        protected bool Alive = true;

        public Creature(string creatureName, IDiet diet, IKingdom kingdom, List<IEnvironment> environment)
        {
            counterID++;
            ID = counterID;
            CreatureName = creatureName;
            MaxEnergy = 100;
            CurrentEnergy = rnd.Next(50, 100);
            MaxHealth = 100;
            CurrentHealth = rnd.Next(50, 100);
            AttackPoints = rnd.Next(5, 20);
            DefPoints = rnd.Next(5, 20);
            AttackRange = rnd.Next(0, 1);
            Kingdom = kingdom;
            Diet = diet;
            Environment = environment;
        }

        public string getCreatureName()
        {
            return CreatureName;
        }

        public List<IEnvironment> getCreatureEnvironment()
        {
            return Environment;
        }
        public void MoveThrough(ITerrain terrain) 
        {

        }

        public IKingdom getCreatureKingdom()
        {
            return Kingdom;
        }

        public IDiet getCreatureDiet()
        {
            return Diet;
        }

        public int Eat(IFood food) 
        {
            if (food.ToString() == Diet.ToString())
            {
                return food.getCalories();
            }
            return 0;
        }

        public int Rest() 
        {
            if (CurrentEnergy <= MaxEnergy) 
            {
                CurrentEnergy += Convert.ToInt32(MaxEnergy * 0.5);
            }
            return CurrentEnergy;
        }

        /*public int Attack() 
        {

        }*/
        /*
        public int BeingAttacked(int AtkPointsOfAttacker)
        {
           
        }
        public void Interact(IInteractable interact)
        {

        }

        public bool Die()
        {
            if CurrentHealth <= 0
                {
                    return false;
                }
            return true;
        }
        */
    }
}
