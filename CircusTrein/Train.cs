using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Train
    {
        public List<Wagon> listWagons;

        public Train(List<Wagon> listWagons)
        {
            this.listWagons = listWagons;
        }


        public void AddWagonIncludingAnimal(Animal animal)
        {

            listWagons.Add(new Wagon(animal));

        }
    }
}
