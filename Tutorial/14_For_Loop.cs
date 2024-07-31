using System;

class _14_For_Loop
{
    // For loop in C#
    static void Main(string[] args)
    {
        // Iterating over the array
        int[] nos = { 1, 2, 3, 4, 5, 6, 7 };

        Console.WriteLine("using Simple For Loop");    
        for (int i = 0; i < nos.Length; i++)
        {
            Console.WriteLine(nos[i]);
        }


        Console.WriteLine("Using For each Loop");
        // for Each Loop
        foreach (int k in nos)
        {
            Console.WriteLine(k);
        }
    }

}

