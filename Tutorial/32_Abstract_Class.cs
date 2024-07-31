using System;

// Inheriting Abstract Class
class _32_Abstract_Class : Bus
{
    static void Main(string[] args)
    {
        _32_Abstract_Class abs = new _32_Abstract_Class();
        abs.BusRoute();

        // Another way of calling
        _32_Abstract_Class bb = new _32_Abstract_Class();
        bb.BusRoute();

        // Static method of Abstract class
        Bus.run();

        // Calling Static method using Inherited Class
        _32_Abstract_Class.run();

        // Calling Non-abstract method
        bb.BusInfo();



    }

    // Implmenting method of abstract class bus
    public override void BusRoute()
    {
        Console.WriteLine("Bus from Vashi to Panvel");
    }
}

// Creating Abstract class
public abstract class Bus
{
    // Creating abstract method
    public abstract void BusRoute();

    // members
    public int name;

    // Static method in abstract class
    public static void run()
    {
        Console.WriteLine("Static Method of Abstract class Buss");
    }

    // Non-abstract Method
    public void BusInfo()
    {
        Console.WriteLine("Bus Info method called from Abstract class bus");
    }
}
