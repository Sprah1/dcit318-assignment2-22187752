using System;

Console.WriteLine("=== Task 1: Inheritance and Method Overriding ===");

Animal genericAnimal = new Animal();
Animal dog = new Dog();
Animal cat = new Cat();

genericAnimal.MakeSound();
dog.MakeSound();
cat.MakeSound();


Console.WriteLine("\n=== Task 2: Abstract Classes and Methods ===");

Shape circle = new Circle(5);
Shape rectangle = new Rectangle(4, 6);

Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");


Console.WriteLine("\n=== Task 3: Interfaces ===");

IMovable car = new Car();
IMovable bicycle = new Bicycle();

car.Move();
bicycle.Move();


// ----- Task 1 classes -----

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}


// ----- Task 2 classes -----

public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }
}


// ----- Task 3 classes -----

public interface IMovable
{
    void Move();
}

public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}