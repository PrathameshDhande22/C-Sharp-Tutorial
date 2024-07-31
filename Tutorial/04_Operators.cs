using System;
class _04_Operators_in_Csharp
{
    public static void Main()
    {
        // Operators in C#
        Console.WriteLine("Operators Example");

        // Assignment Operators : Single equal
#pragma warning disable
        int a = 122;
        bool isPerson = false;


        // Arithmetic Operators

        // Addition
        int first = 100;
        int second = 400;
        Console.WriteLine("Addition : " + (first + second));

        // Subtraction
        Console.WriteLine("Subtraction : " + (second - first));

        // Remainder or Modulus Operator
        Console.WriteLine("Modulus Operator : " + (4 % 3)); // Returns the remainder

        // Division
        Console.WriteLine("Division : " + (second / first));

        // Multiplication 
        Console.WriteLine("Multiplication : " + (first * second));


        // Ternary Operator
        bool isSameNumber = second == first ? true : false;
        Console.WriteLine(isSameNumber);


        // Comparison Operator
        second = first;
        if (second == 100 && first == 100)
        {
            Console.WriteLine("Both Number are Same");
        }

        // Greater than equal to
        second = 400;
        if (first <= second)
        {
            Console.WriteLine("First Number is Less and its Correct");
        }

        // Bitwise Operator

        // Binary And Operator
        Console.WriteLine(4 & 5);// result should be 100 & 101 = 100 i.e 4

        // Binary OR Operator
        Console.WriteLine(4 | 5); // result should be 100 | 101 = 101 i.e 5

        // Binary XOR Operator
        Console.WriteLine(4 ^ 5); // result should be 100 ^ 101 = 001 i.e 1

        // Binary Ones Complement
        Console.WriteLine(~4); // result should be 4 = 100 and 011 should be  -5

        // Left Shift Operator
        Console.WriteLine(5 << 2); // result should be 5 = 101 i.e 101<<3=  10100 = 20

        // Right Shift Operator
        Console.WriteLine(5 >> 2); // result should be 5 =101 i.e 101>>2 = 001 =1


    }
}