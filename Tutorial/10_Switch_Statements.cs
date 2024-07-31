using System;


class _10_Switch_Statements
{
    // Switch Statement Example

    static void Main(string[] args)
    {

        Console.WriteLine("Enter a Number: ");
        int nos = int.Parse(Console.ReadLine());

        // Simple Switch Statement
        switch (nos)
        {
            case 1:
                Console.WriteLine("Number is One");
                break;
            case 2:
                Console.WriteLine("Number is Two");
                break;
            case 3:
                Console.WriteLine("Number is Three");
                break;
            default:
                Console.WriteLine("Enter Number between 1,2,3");
                break;
        }

        // Grouping Multiple Cases in Switch Statement
        switch (nos)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("Number is {0}", nos);
                break;
            default:
                Console.WriteLine("Enter Number between 1,2,3");
                break;
        }
       
    }

}

