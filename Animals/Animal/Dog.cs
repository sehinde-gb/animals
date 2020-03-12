using System;
namespace Animals.Animal
{
    class Dog : Animal
    {
        public int spotCount;

        public void Bark()
        {
            Console.WriteLine("Woof");
            base.happiness += 0.1f;
        }
    }
}
