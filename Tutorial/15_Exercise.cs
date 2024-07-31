using System;


class _15_Exercise
{

    static void Main(string[] args)
    {
        // Check if the Number Entered by User is Prime or not
        Console.Write("Enter a Number : ");
        int no = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (no == 0 || no == 1)
        {
            Console.WriteLine("Number is not prime");

        }
        else
        {
            for (int i = 2; i <= no / 2; i++)
            {
                if (no % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        Console.WriteLine(isPrime);


        // Draw a parallelogram
        Console.Write("Enter The Height: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Enter the Length: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("Enter Character to Print: ");
        string character = Console.ReadLine();

        for (int i = 0; i < height; i++)
        {
            // Print Spaces
            for (int space = 0; space < i; space++)
            {
                Console.Write(" ");
            }
            // Print Character
            for (int j = 0; j < length; j++)
            {
                Console.Write(character);
            }
            Console.WriteLine();

        }

    }

}

