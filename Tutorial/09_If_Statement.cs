using System;



class _09_If_Statement
{
    // Conditional Statements
    static void Main(string[] args)
    {

        Console.Write("Enter a Number: ");
        int number = int.Parse(Console.ReadLine());

        // if Else Statement
        if (number == 1)
        {
            Console.WriteLine("Number is One");
        }
        else if (number == 2)
        {
            Console.WriteLine("Number is Two");
        }
        else
        {
            Console.WriteLine("Enter Number one and Two only");
        }

        // nested if else
        if (number % 2 == 0)
        {
            if (number % 10 == 0)
            {
                Console.WriteLine("Number is Divisible by 10 & 2");
            }
            else
            {
                Console.WriteLine("Number is Not Divisible by 10 but by 2");
            }
        }
        else
        {
            Console.WriteLine("Number is not divisible by 10 or 2");
        }

        // Logical And
        if (number % 2 == 0 && number == 3)
        {
            Console.WriteLine("Number is divisible by 2");
        }

        // Bitwise And
        if (number % 2 == 0 & number == 3)
        {
            Console.WriteLine("Number you got it");
        }
        else
        {
            Console.WriteLine("These is the magic of binary or ");
        }


    }

}

