using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_OOP
{
    public class Animal
    {
        public string FavoriteFood { get; set; }
        public string Name { get; set; }
        private readonly int animalCode;
        
        public int AnimalCode
        {
            get
            {
                return this.animalCode;
            }
        }
        private static int count;

        static Animal()
        {
            count = 0;     
        }

        public Animal(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavoriteFood = favoriteFood;

            count++;
            animalCode = count;               
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} eats now {FavoriteFood}");
        }

        public override string ToString()
        {
            return String.Format($"ID {animalCode}: have the name {Name} and likes to eat {FavoriteFood}.");
        }


    }
}
