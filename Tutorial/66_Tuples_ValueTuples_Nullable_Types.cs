using System;

class _66_Tuples_ValueTuples_Nullable_Types
{
    static void Main(string[] args)
    {
        // Defining tuple
        Tuple<int, int, string> tuple = new Tuple<int, int, string>(23, 56, "Prathamesh");

        // Accessing the value from the tuple
        Console.WriteLine("Value at tuple item 3 {0}", tuple.Item3);

        // Another Way to create tuple
        Tuple<string, int, string, int> othertuple = Tuple.Create<string, int, string, int>("John", 2, "Hello", 4);
        // Printing the whole tuple
        Console.WriteLine(othertuple);

        // Nested Tuple
        Tuple<int, int> nestedTuple = Tuple.Create<int, int>(10, 20);
        Tuple<int, Tuple<int, int>> outerTuple = Tuple.Create<int, Tuple<int, int>>(11, nestedTuple);
        Console.WriteLine(outerTuple);
        // Accesing the value from the nested tuple
        Console.WriteLine("Value from nested Tuple {0}", outerTuple.Item2.Item2);

        // Calling the method
        Console.WriteLine(ReturnEmployee());
    }

    // Method with return type as Tuple
    static Tuple<int, int> ReturnEmployee()
    {
        return Tuple.Create<int, int>(10, 10);
    }
}

