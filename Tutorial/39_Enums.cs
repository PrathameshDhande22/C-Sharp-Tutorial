using System;
class _39_Enums
{

    static void Main(string[] args)
    {
        // Using Enums
        Console.WriteLine("Today is {0}", Weeks.Saturday);

        Console.WriteLine();
        // Values
        foreach(int val in Enum.GetValues(typeof(Weeks)))
        {
            Console.WriteLine(val);
        }

        Console.WriteLine();
        // Values
        foreach (int val in Enum.GetValues(typeof(Category)))
        {
            Console.WriteLine(val);
        }

    }

}


// Creating Enums
public enum Weeks
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

// Assigning values to enums
public enum Category
{
    Shopping=1,
    Grocery=2,
    Traveling=3
}

