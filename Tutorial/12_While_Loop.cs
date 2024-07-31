using System;

class _12_While_Loop
{
    // While Loops in C#
    static void Main(string[] args)
    {
        // Printing Table of User Choice using While Loop

        Console.WriteLine("Enter Number: ");
        int tableof = int.Parse(Console.ReadLine());

        int i = 1;
        Console.WriteLine("Table of {0}", tableof);
        while (i <= 10)
        {
            Console.WriteLine("{0} X {1} = {2}", tableof, i, tableof * i);
            i++;
        }
    }

}

