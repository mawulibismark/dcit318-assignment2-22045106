using System;

// Abstract base class
abstract class Shape
{
    public abstract double GetArea();
}

// Derived class Circle
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Derived class Rectangle
class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double GetArea()
    {
        return Length * Width;
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create Circle and Rectangle objects
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(10, 4);

        // Display their areas
        Console.WriteLine("Circle Area: " + circle.GetArea());
        Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
    }
}