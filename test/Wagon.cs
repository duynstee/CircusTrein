using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein
{
    class Wagon
    {
        private List<Animal> animals;

        int capacity = 0;
        int maxCapacity = 10;

        public Wagon()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
