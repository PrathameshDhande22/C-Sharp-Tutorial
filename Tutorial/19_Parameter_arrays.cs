using System;
class _19_Parameter_arrays
{
    // Parameter Arrays

    static void Main(string[] args)
    {
        // Calling the params Array Method
        PrintArrays(23,"Prathamesh", "Prashant", "Dhande", "John", "Clever", "Union");

    }

    // Creating the function with Parameter arrays
    public static void PrintArrays(int x,params string[] names)
    {
        Console.Write(x);
        Console.WriteLine("length of the arguments passed: {0}", names.Length);
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

}
