using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Max = new Dog("Max", "male", "Lady", "Rocky");
            Dog Rocky = new Dog("Rocky", "male", "Molly", "Sam");
            Dog Sparky = new Dog("Sparky", "male");
            Dog Buster = new Dog("Buster", "male", "Lady", "Sparky");
            Dog Sam = new Dog("Sam", "male");
            Dog Lady = new Dog("Lady", "female");
            Dog Molly = new Dog("Molly", "female");
            Dog Coco = new Dog("Coco", "female", "Molly ", "Buster");

            Console.WriteLine(Buster.fathersName());
            Console.WriteLine(Buster.HasSameMotherAs(Max));
            Console.ReadKey();
        }
    }
}
