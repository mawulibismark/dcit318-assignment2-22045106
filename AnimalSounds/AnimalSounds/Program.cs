using System;

// Base class
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class Dog
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Derived class Cat
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create instances
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        // Call MakeSound() on each instance
        animal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();
    }
}