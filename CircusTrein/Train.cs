using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Train
    {
        List<Animal> animalList;
        
        public List<Wagon> listWagons;

        public Train(List<Wagon> listWagons)
        {
            this.listWagons = listWagons;
        }

        public List<Animal> OrderList(List<Animal> animalList)
        {
                var OrderByFoodType = animalList
                    .OrderBy(z => z.FoodType)
                    .ThenByDescending(z => z.Size).ToList();

                return OrderByFoodType;
        }
    }
}
