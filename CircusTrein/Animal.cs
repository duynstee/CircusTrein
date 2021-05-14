using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    

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
    }
}
