using System;


class _11_Goto_Keyword
{

    static void Main(string[] args)
    {

    // defining a label
    restart:
        Console.Write("Enter a Number : ");
        int nos = int.Parse(Console.ReadLine());
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

        Console.WriteLine("Enter Yes Or No:");
        string userChoice = Console.ReadLine().ToLower();
        if (userChoice == "yes")
        {
            // goto keyword to redirect from the restart label
            goto restart;
        }
        else
        {
            Console.WriteLine("Thank You for Choosing Number");
        }
    }

}
