using System;


class _06_Datatype_Conversion
{

    public static void Main(string[] args)
    {
        // Datatype conversion or typeCasting 

        // Implicit Conversion: Done by the compiler itself.
        int a = 100;
        float b = a;
        double d = b;

        Console.WriteLine(a + " " + b + " " + d);

        // Explicit Conversion
        float floatValue = 1223322.454f;
        // Converting Float value to Integer Value
        int value = (int)floatValue;
        Console.WriteLine(value);

        // Another method by using Convert Class
        int anotherValue = Convert.ToInt32(floatValue);
        Console.WriteLine(anotherValue);

        /*float biggerNo = 121111111111111111111113423424.434f;
        int intNo = (int)biggerNo;
        Console.WriteLine("Converted using (int) " + intNo);
        int byClass = Convert.ToInt32(biggerNo);
        Console.WriteLine("Converted Using convert Class "+byClass);*/


        // Parse Method
        string nobyUser = "1000";
        int noConverted = int.Parse(nobyUser);
        Console.WriteLine("Converted by Parse Method : {0}", noConverted);

        // Try Parse Method
        int result = 12;
        nobyUser = "1004TH";
        // These was failed due to th in the string it must be a pure number.
        int.TryParse(nobyUser, out result);
        Console.WriteLine("Converted by Try Parse Method : {0}", result);

    }

}