/* Built in Types*/
using System;

class _03_Built_In_Types
{
    public static void Main()
    {

        // Variable Declaration using var keyword
        var stringify = "String";
        Console.WriteLine(stringify);
        stringify = "another string";
        Console.WriteLine(stringify);

        // Variable declaration using const keyword
        const string greet = "Good Morning Sir";

        Console.WriteLine(greet);

        //Boolean Data type
        Boolean b = true;
        Console.WriteLine(b);
        bool c = false;
        Console.WriteLine(c);


        // Integral Datatypes

        // Integer data type 
        int intdata = -123;
        Console.WriteLine(intdata);
        // unsigned integer data types holds only positive numbers
        uint uintdata = 1243;
        Console.WriteLine(uintdata);

        // Getting maximum and minimum value of an integer
        Console.WriteLine("Min value of an Integer " + int.MinValue);
        Console.WriteLine("Max Value of an Integer " + int.MaxValue);

        //Float Datatype can store upto six or seven decimal digits
        float floatdata = 100.12324454f;
        Console.WriteLine(floatdata);

        //double datatype can store upto 15 decimal digits
        double d = 1.2323278;
        Console.WriteLine(d);

        // Long Datatype
        long l = 100000234234224234L;
        Console.WriteLine(l);

        ulong ul = 2342342;
        Console.WriteLine(ul);

        // Decimal Datatypes
        decimal dd = 133.243234534543356353m;
        Console.WriteLine(dd);

        // String Datatypes
        string st = "Prathamesh Dhande";
        Console.WriteLine(st);

        // Char Datatype
        char ch = 'A';
        Console.WriteLine(ch);

        // String datatype escape Character
        string newstr = "C:\\Windows\\Users\\Local\\window.exe";
        Console.WriteLine(newstr);

        // Verbatim Literal
        string vbliteral = @"One\nTwo\nThree\nFour";
        Console.WriteLine(vbliteral);
        Console.WriteLine("One\nTwo\nThree\nFour");

    }
}