using System;

class _18_Out_Parameters
{
    // Out Parameter of the methods
    static void Main(string[] args)
    {
        int addition, subtraction;
        // Call method
        int square = (int)Calculate(3, 3, out addition, out subtraction);
        Console.WriteLine("Square is {0}, Addition is {1}, Subtraction is {2}", square, addition, subtraction);
    }

    // Method with Out Parameter
    public static double Calculate(int number, int raiseto, out int add, out int sub)
    {
        add = number + raiseto;
        sub = number - raiseto;
        return Math.Pow(number, raiseto); ;
    }

}

