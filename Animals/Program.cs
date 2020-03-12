using System;
using Animals.Animal;

namespace Animals
{
    class MainClass
    {

     


        public static void Main(string[] args)
        {
            Dog spotty = new Dog();
            spotty.name = "Spotty";
            spotty.age = 4;
            spotty.happiness = 0.8f;
            spotty.spotCount = 25;
            spotty.PrintBase();
            spotty.Bark();
            Console.WriteLine("New Happiness: " + spotty.happiness);

            Console.WriteLine();

            Cat heisenberg = new Cat();
            heisenberg.name = "Heisenberg";
            heisenberg.age = 14;
            heisenberg.happiness = 0.3f;
            heisenberg.cuteness = 0.4f;
            heisenberg.PrintBase();
            heisenberg.Meow();

            Console.ReadKey();
        }
    }
}
