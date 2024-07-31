using System;
class _47_ConvertString_ToString
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer() { City = "Boisar" };
        Console.WriteLine(Convert.ToString(c1.Name));// Handles Null
        Console.WriteLine(c1.Name.ToString());  // Throws NullReference Exception
    }
}


