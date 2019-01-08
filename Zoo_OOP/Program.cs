using System;

namespace Zoo_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Branch testing on GIT.");
            Animal animal = new Lion("Lord", "patatoes");
            Animal animal2 = new Animal("Sisi", "lucerne");
            Animal animal3 = new Zebra("Lulu", "grass");
            Animal animal4 = new Animal("Titi", "carrots");
            Animal animal5 = new Animal("Fofo", "carrots");
            Animal animal6 = new Animal("Riri", "carrots");

            Zoo zoo1 = new Zoo("Interantiona Zoo");
            Zoo zoo2 = new Zoo("Local Zoo");

            zoo1.AddAnimal(animal2);
            zoo1.AddAnimal(animal4);
            zoo1.AddAnimal(animal);

            zoo2.AddAnimal(animal3);
            zoo2.AddAnimal(animal5);
            zoo2.AddAnimal(animal6);

            Console.WriteLine(zoo1);
            Console.WriteLine(zoo2);

            zoo1.EatAllAnimals();
            zoo2.EatAllAnimals();

            zoo2.Remove(animal3.AnimalCode);
            Console.WriteLine(zoo2);

            Console.WriteLine("------------");

            ZooFederation.TransferAnimals(zoo1, zoo2, animal);
            Console.WriteLine(zoo1);
            Console.WriteLine(zoo2);
        }
    }
}
