using System;


/* Reading and Writing to Console Tutorial */
class _02_Reading_and_Writing_Console
{
    public static void Main()
    {
        Console.WriteLine("Enter Your Name: ");

        //Reading from Console using ReadLine method of Console Class
        string username = Console.ReadLine();

        //Using String Concatenation to 
        Console.WriteLine("Welcome to C# " + username);

        //PlaceHolder Syntax to write the string just like the python f-string
        Console.WriteLine("hello {0}", username);
    }
}