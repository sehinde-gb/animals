using System;

namespace Animals
{
    class MainClass
    {

        class Animal
        {
            public string name;
            public int age;
            public float happiness;

            public void PrintBase ()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Happiness: " + happiness);
            }
        }

        class Dog : Animal
        {
            public int spotCount;

            public void Bark ()
            {
                Console.WriteLine("Woof");
                base.happiness += 0.1f;
            }
        }

        class Cat : Animal
        {
            public float cuteness;

            public void Meow()
            {
                Console.WriteLine("MEOW");
            }
        }


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
