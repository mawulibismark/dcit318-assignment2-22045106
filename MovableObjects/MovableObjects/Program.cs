using System;

// Define the interface
interface IMovable
{
    void Move();
}

// Car implements IMovable
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Bicycle implements IMovable
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create instances
        Car car = new Car();
        Bicycle bicycle = new Bicycle();

        // Call Move() on each instance
        car.Move();
        bicycle.Move();
    }
}