using animalSpace.Interfaces;
using animalSpace.Model.InteractablesAndItems;
using animalSpace.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
        protected string creatureName;
        protected int maxEnergy;
        protected int currentEnergy;
        protected int maxHealth;
        protected int currentHealth;
        protected int attackPoints; 
        protected int defPoints;
        protected int attackRange;
        protected IKingdom kingdom;
        protected IDiet diet;
        protected List<IEnvironment> listEnvironments;
        protected int energyCost;
        protected bool alive = true;

        public IKingdom Kingdom
        {
            get => kingdom;
            set
            {
                if (value != null) kingdom = value;
                else throw new InvalidOperationException("Debe seleccionar un Reino");
            }
        }

        public string CreatureName
        {
            get => creatureName;
            set
            {
                if (value != null) creatureName = value;
                else throw new InvalidOperationException("Debe especificar un Nombre");
            }
        }
        public IDiet Diet
        {
            get => diet;
            set
            {
                if (value != null) diet = value;
                else throw new InvalidOperationException("Debe especificar una Dieta");
            }
        }

        public int MaxEnergy
        {
            get => maxEnergy;
            set
            {
                if (value > 0) maxEnergy = value;
                else throw new InvalidOperationException("La energía máxima debe ser mayor a 0");
            }
        }
        public int MaxHealth
        {
            get => maxHealth;
            set
            {
                if (value > 0) maxHealth = value;
                else throw new InvalidOperationException("La vida máxima debe ser mayor a 0");
            }
        }
        public int CurrentHealth
        {
            get => currentHealth;
            set
            {
                if (value <= 0)
                {
                    currentHealth = 0;
                    Alive = true;
                    throw new Exception("Está muerto");
                }
                else if (value > MaxHealth)
                {
                    currentHealth = MaxHealth;
                }
                else
                {
                    currentHealth = value;
                }
            }
        }

        public int AttackPoints 
        {
            get => attackPoints;
            set => attackPoints = value;
        }
        public int DefPoints 
        {
            get => defPoints;
            set => defPoints = value;
        }
        public int AttackRange 
        { 
            get => attackRange;
            set => attackRange = value;
        }
        public int CurrentEnergy
        {
            get => currentEnergy;
            set
            {
                if (value < 0)
                {
                    currentEnergy = 0;
                }
                else if (value > MaxEnergy)
                {
                    currentEnergy = MaxEnergy;
                }
                else
                {
                    currentEnergy = value;
                }
            }
        }
        public bool Alive 
        {
            get => alive;
            set => alive = value;
        }

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

        public int getCreatureId()
        {
            return ID;
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

        public void Eat(IInteractable food) 
        {
            
            if (Diet.CanEat(food))
            {
                food.Interact(this);
            }
            else
            {
                MessageBox.Show("Qué estas tratando de comer, zoquete");
            }

        }

        public void AddEnergy(int energy)
        {
            currentEnergy += energy;
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
                    MessageBox.Show($"Ataque exitoso, le quitaste {interactionResult} de vida al rival");
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
