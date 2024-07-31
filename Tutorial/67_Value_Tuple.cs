using System;
class _67_Value_Tuple
{
    static void Main(string[] args)
    {
        // Value Tuple

        // Creating the valuetuple
        ValueTuple<int, string> vtuple = ValueTuple.Create<int, string>(23, "Hello");

        // Printing ValueTuple
        Console.WriteLine(vtuple);

        // Another way of creating valuetuple using parenthesis ()
        ValueTuple<string, string, string> stringnames = ("a", "b", "c");
        Console.WriteLine(stringnames);

        // Accessing value from the tuple
        Console.WriteLine("Value of tuple at Item2 : {0}",stringnames.Item2);

        // Changing the value of the tuple 
        stringnames.Item2 = "abc";
        Console.WriteLine(stringnames);

        // Calling the method
        Console.WriteLine(GiveNames());

        // Passing the Value Tuple as a argument to the method
        Console.WriteLine(Add((1,2)));
        
    }

    // method with return type as ValueTuple
    static (int,string,int) GiveNames()
    {
        return (1, "Prathamesh", 200);
    }

    // method with parameter as ValueTuple
    static int Add((int,int) nos)
    {
        return nos.Item2+ nos.Item1;
    }
}
