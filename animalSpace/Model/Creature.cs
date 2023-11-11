using animalSpace.Interfaces;
using animalSpace.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animalSpace.Model
{
    internal class Creature : IPositionable
    {
        Random rnd = new Random();
        protected static int counterID = 0;
        protected int ID;
        protected string CreatureName;
        protected int MaxEnergy;
        protected int CurrentEnergy;
        protected int MaxHealth;
        protected int CurrentHealth;
        protected int AttackPoints; 
        protected int DefPoints;
        protected int AttackRange;
        protected IKingdom Kingdom;
        protected IDiet Diet;
        protected List<IEnvironment> listEnvironments;
        protected int energyCost;
        protected bool Alive = true;



        public List<IEnvironment> ListEnvironments
        {
            get => listEnvironments;
            set
            {
                if (value != null) 
                    listEnvironments = value;
                else 
                    throw new InvalidOperationException("Debe seleccionar al menos un Habitat");
            }
        }

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
            ListEnvironments = environment;
            energyCost = 25;
        }
        public int getAtkPoints() 
        {
            return AttackPoints;
        }
        public int getCurrentHealth()
        {
            return CurrentHealth;
        }
        public int getDefPoints()
        {
            return DefPoints;
        }
        public int getCurrentEnergy()
        {
            return CurrentEnergy;
        }
        public List<IEnvironment> CompatibleEnvironments()
        {
            return ListEnvironments;
        }
        public List<string> getEnvironments() 
        {
            List<string> environmentsList = new List<string>();
            foreach (var environment in listEnvironments)
            {
                environmentsList.Add(environment.ToString());
            }
            return environmentsList;
        }
        public string getEnvironmentsString()
        {
            string env = "";
           
            foreach (var environment in listEnvironments)
            {
                env +=environment.ToString()+" ";
            }
            return env;
        }

        public string getCreatureName()
        {
            return CreatureName;
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

        public void Attack(Creature attackedCreature) 
        {
            if(IsEnergyToDoActionEnough(this.CurrentEnergy))
            {
                int interactionResult = receiveAttack(this);
                if (interactionResult < 0)
                {
                    CurrentHealth -= interactionResult;
                    MessageBox.Show($"Fuiste mas debil que la criatura atacada, perdiste {interactionResult} puntos de vida");
                }
                else
                {
                    attackedCreature.CurrentHealth -= interactionResult;
                    MessageBox.Show($"Ataque exitoso, le quitaste {interactionResult}al rival");
                }
            }
        }

        public int receiveAttack(Creature attackingCreature) 
        {
            int damage;
            damage = (this.DefPoints + Dice.ThrowDice(6)) - (attackingCreature.AttackPoints + Dice.ThrowDice(6));
            return damage;
        }
        
        public bool IsEnergyToDoActionEnough(int energy) 
        {
            if (energy > energyCost) 
            {
                energy -= energyCost;
                return true;
            }
            return false;
        }
        /*
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
