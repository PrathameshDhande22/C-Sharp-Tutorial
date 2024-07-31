using System;


class _16_Method
{
    // Methods in C#
    static void Main(string[] args)
    {
        // Calling the Static methods
        Print10Numbers();

        // Calling the instance methods requires creating the object of the class
        _16_Method methods = new _16_Method();
        methods.PrintEvenNumbers();

        // Calling the Methods by Passing the Arguments
        int result = methods.Add(3, 4);
        Console.WriteLine(result);

        // Named Arguments
        methods.Add(secondNo: 4, firstNo: 3);

    }

    // Defining Methods
    public static void Print10Numbers()
    {
        Console.WriteLine("Printing 10 Numbers");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    // Defining instance methods
    public void PrintEvenNumbers()
    {

        Console.WriteLine("printing Even Number from 1 to 20");
        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }
    }


    // Defining instance methods with parameters and return type
    public int Add(int firstNo, int secondNo)
    {
        return firstNo + secondNo;
    }

}
