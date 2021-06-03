using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Task
    {
        int count = 0;
        
        public List<Animal> OrderList(List<Animal> animalList)
        {
            var OrderByFoodType = animalList
                .OrderBy(z => z.FoodType)
                .ThenByDescending(z => z.Size).ToList();

            return OrderByFoodType;
        }
        
        public List<Wagon> SortAnimalsOverTrain()
        {
            var wagonlist;
            return wagonlist;
        }
        
        public void AddWagonIncludingAnimal(Animal animal)
        {
            listWagons.Add(new Wagon(animal));

        }
        private void AddListAnimal()
        {

        }

    }
}
