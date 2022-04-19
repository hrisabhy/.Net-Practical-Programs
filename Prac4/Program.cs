using System;

namespace Prac4
{
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating");
        }
    }
    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Dog dog1 = new Dog();
            dog1.eat();
            dog1.bark();
            
        }
    }
}
