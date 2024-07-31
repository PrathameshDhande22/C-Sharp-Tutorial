using System;
using System.Runtime.CompilerServices;

class _22_Static_Instance_members
{
    // Static and Instance Members of Class
    static void Main(string[] args)
    {
        // Calling Class object
        Circle c1 = new Circle(3);
        Console.WriteLine(c1.CalculateArea());
        // Calling Static Methods and Static Variables
        Circle.Print();
        Console.WriteLine(Circle.PI);
    }


}

class Circle
{
    // Static Variable
    public static float PI = 3.14f;
    private int radius;

    // Static Constructor
    static Circle()
    {
        Console.WriteLine("Static Constructor Called");
    }

    // Instance Constructor
    public Circle(int radius)
    {

        Console.WriteLine("Instance Constructor Called");
        this.radius = radius;
    }

    // Instance Methods
    public float CalculateArea()
    {
        return Circle.PI * this.radius;
    }

    // Static Methods
    public static void Print()
    {
        Console.WriteLine("Circle Area Calculator");
    }
}