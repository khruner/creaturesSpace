using animalSpace.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model.InteractablesAndItems
{
    internal class Food : IInteractable
    {
        protected static int id_counter = 0;
        protected int Id;
        protected int calories;
        protected List<IDiet> diet;
        protected string name;

        public string Name 
        { 
            get => name;
            set => name = value;
        }
        public List<IDiet> Diet 
        {
            get => diet;
            set => diet = value;
        }
        public int Calories 
        { 
            get => calories;
            set => calories = value;
        }

        public string DietNames
        {
            get
            {
                string listOfDiets = "";
                foreach (var diet in Diet)
                {
                    listOfDiets = string.Join(", ", Diet);
                }
                return listOfDiets;
            }
        }

        public Food(string name, List<IDiet> diet, int calories)
        {
            id_counter++;
            Id = id_counter;
            Name = name;
            Diet = diet;
            Calories = calories;
        }

        //public Food() { }

        public int GetId()
        {
            return Id;
        }

        public int getCalories()
        {
            return Calories;
        }
        
        public void Interact(Creature creature)
        {
            creature.AddEnergy(Calories);
        }

        public string getDiet()
        {
            return DietNames;
        }
    }
}
