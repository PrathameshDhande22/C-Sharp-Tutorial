using System;
using System.Collections.Generic;
class _54_Generic_Class_List
{
    static void Main(string[] args)
    {
        List<string> lists = new List<string>();
        lists.Add("Socket"); // Adds only one element at a time
        lists.Add("React");
        lists.Add("Java");
        lists.Add("CPP");

        // Adds all the elements in a given list or range
        Console.WriteLine("Example of AddRange()");
        lists.AddRange(new string[] { "JavaScript", "Python","R","Ruby"});

        foreach (string lang in lists)
        {
            Console.WriteLine(lang);
        }

        // Get Range Method
        Console.WriteLine("\nExample of GetRange()");
        foreach(string ll in lists.GetRange(3, 2)) // should return CPP, JavaScript
        {
            Console.WriteLine(ll);
        }

        // Insert Range
        Console.WriteLine("\nExample of InsertRange()");
        lists.InsertRange(2, new string[] { "Perl", "Go", "Dart" });
        foreach (string lang in lists)
        {
            Console.WriteLine(lang);
        }

        // Removes Range
        Console.WriteLine("\nExample of RemoveRange()");
        lists.RemoveRange(3, 5);
        foreach (string lang in lists)
        {
            Console.WriteLine(lang);
        }

    }
}

