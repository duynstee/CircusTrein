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
                new Animal(FoodType.Carnivore, Size.Small),
                new Animal(FoodType.Herbivore, Size.Big),
                new Animal(FoodType.Carnivore, Size.Medium),
                new Animal(FoodType.Herbivore, Size.Medium),
                new Animal(FoodType.Herbivore, Size.Small),
                new Animal(FoodType.Herbivore, Size.Small),
                new Animal(FoodType.Carnivore, Size.Big),
                new Animal(FoodType.Herbivore, Size.Big),
                new Animal(FoodType.Carnivore, Size.Big),
                new Animal(FoodType.Herbivore, Size.Medium),
                new Animal(FoodType.Carnivore, Size.Small),
                new Animal(FoodType.Herbivore, Size.Small),
            };
            List<Wagon> listwagons = new List<Wagon>();
            Task task = new Task();
            Train Train = new Train(listwagons);
            var OrderByFoodType = task.OrderList(animalList);

            
            foreach (Animal Animal in OrderByFoodType)
            {
                Console.WriteLine(Animal);
            }
            Console.ReadLine();
            


            foreach (Animal Animal in animalList)
            {
                if (Animal.FoodType == FoodType.Carnivore)
                {
                    //Train.AddWagonIncludingAnimal(Animal);
                }
                else
                {
                  
                }
            }

        }
        

    }
}
