using System;
using System.Collections.Generic;
class _55_Sorting_Simple
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();

        // Sorting simple types like string, char, int, double, float are easy but we can't sort user-defined objects
        list.AddRange(new int[] { 11, 45, 12, 78, 01, 5, 12 });

        Console.WriteLine("Before Sorting");
        foreach (int i in list)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        list.Sort();
        Console.WriteLine("After Sorting");
        foreach (int i in list)
        {
            Console.Write(i + " ");
        }
    }

}


