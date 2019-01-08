using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_OOP
{
    public static class ZooFederation
    {
        public static void TransferAnimals(Zoo zooSend, Zoo zooReceive, Animal animal)
        {
            if (zooSend.IndexOf(animal.AnimalCode) >= 0)
            {
                zooSend.Remove(animal.AnimalCode);
                zooReceive.AddAnimal(animal);
                Console.WriteLine("The animal was transfered.");
            }
            else
            {
                Console.WriteLine("This animal doesn't belong to the source Zoo.");
            }
            
        } 

        static ZooFederation() { }
    }
}
