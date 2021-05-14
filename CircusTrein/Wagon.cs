using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Wagon
    {
        public List<Animal> animals;

        int capacity = 0;
        int maxCapacity = 10;

        public Wagon()
        {

        }

        public Wagon(List<Animal> animals, Animal animal)
        {
            this.animals = animals;
            animals.Add(animal);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
