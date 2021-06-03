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

    public enum Size
    {
        Small = 1,
        Medium = 3,
        Big = 5
    }

    class Animal
    {
        public FoodType FoodType { get; set; }
        public Size Size { get; set; }

        public Animal(FoodType foodtype, Size size)
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
