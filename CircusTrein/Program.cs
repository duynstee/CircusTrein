using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>
            {
                new Animal(FoodType.Carnivore, 1),
                new Animal(FoodType.Herbivore, 5),
                new Animal(FoodType.Carnivore, 3),
                new Animal(FoodType.Herbivore, 3),
                new Animal(FoodType.Herbivore, 1),
                new Animal(FoodType.Herbivore, 1),
                new Animal(FoodType.Carnivore, 5),
                new Animal(FoodType.Herbivore, 5),
                new Animal(FoodType.Carnivore, 5),
                new Animal(FoodType.Herbivore, 3),
                new Animal(FoodType.Carnivore, 1),
                new Animal(FoodType.Herbivore, 1),
            };
            List<Wagon> listwagons = new List<Wagon>();
            Task task = new Task();
            Train Train = new Train(listwagons);
            
            var OrderByFoodType = animalList
                .OrderBy(z => z.FoodType)
                .ThenBy(z => z.Size).ToList();

            foreach (Animal Animal in animalList)
            {
                if (Animal.FoodType == FoodType.Carnivore)
                {
                    Train.AddWagonIncludingAnimal(Animal);
                }
                else
                {
                  
                }
            }

        }
        

    }
}
