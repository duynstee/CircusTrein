using System;
using System.Collections.Generic;
using System.Text;

    namespace CircusTrein
    {
        public List<Animal> animalList;
    
        public enum FoodType
        {
            Carnivore,
            Herbivore
        } 
   
        class Animal
        {
            public FoodType FoodType { get; set; }
            public int Size { get; set; }

            public Animal(FoodType foodtype, int size)
            {
                this.FoodType = foodtype;
                this.Size = size;
            }

            public override string ToString()
            {
                return string.Format("Het dier is een {0}, en de grootte is {1}", FoodType, Size);
            }
            Animal.animalList.Add()
        }
    }
