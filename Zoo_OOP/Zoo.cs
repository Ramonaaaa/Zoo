using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_OOP
{
    public class Zoo
    {
        public string Name { get; set; }
        List<Animal> animalsList;

        public Zoo(string name)
        {
            this.Name = name;
            animalsList = new List<Animal>();
        }

        public void EatAllAnimals()
        {
            foreach (Animal animal in animalsList)
            {
                animal.Eat();
            }
        }

        public void AddAnimal(Animal animal)
        {
            animalsList.Add(animal);
        }

        public void Remove(int codAnimal)
        {
            var index = IndexOf(codAnimal);
            if (index >=0)
            {
                animalsList.RemoveAt(index);
                Console.WriteLine($"The {codAnimal} was removed.");
            }
            else
            {
                Console.WriteLine(codAnimal + " doesn't belong to this Zoo.");
            }
        }

        public int IndexOf(int IdAnimal)
        {
            for (int i = 0; i < animalsList.Count; i++)
            {
                if (IdAnimal == animalsList[i].AnimalCode)
                {
                    return i;
                }               
            }

            return -1;
        }

        public override string ToString()
        {
            string output = Name + " have the following animals: ";
            foreach (Animal animal in animalsList)
            {
                output += "\n" + animal.ToString();
            }
            return output;
        }
    }
}
