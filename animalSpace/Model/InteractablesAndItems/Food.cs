﻿using animalSpace.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model.InteractablesAndItems
{
    internal class Food : IInteractable, IFood
    {
        protected static int id_counter = 0;
        protected int Id;
        protected int Calories;
        protected List<IDiet> Diet;
        protected string Name { get; set; }

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

        public int GetId()
        {
            return Id;
        }

        public int getCalories()
        {
            return Calories;
        }
        
        public void Interact(ICreature creature)
        {
            creature.Eat(this);
        }

        public string getDiet()
        {
            return DietNames;
        }
    }
}
