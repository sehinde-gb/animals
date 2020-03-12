using System;
namespace Animals.Animal
{
    class Animal
    {
        public string name;
        public int age;
        public float happiness;

        public void PrintBase()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
        }
    }
}
