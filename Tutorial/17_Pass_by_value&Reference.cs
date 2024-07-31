using System;


class _17_Pass_by_value_Reference
{
    // Pass the parameter by value and reference

    static void Main(string[] args)
    {
        int i = 0;
        // Pass by Value Method call
        SimpleMethodByValue(i);
        Console.WriteLine("Pass by Value After: {0}", i);

        // Pass by Reference Method call
        SimpleMethodByReference(ref i);
        Console.WriteLine("Pass by Reference After:{0}", i);
    }

    // Pass by Value Method
    public static void SimpleMethodByValue(int j)
    {
        j = 202;
    }

    // Pass by Reference Method
    public static void SimpleMethodByReference(ref int j)
    {
        j = 203;
    }

}

