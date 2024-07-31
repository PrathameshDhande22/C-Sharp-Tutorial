using System;


class _31_Explicit_Interface
{

    static void Main(string[] args)
    {
        // Calling the interface method 1
        ProgrammingLanguage pl = new ProgrammingLanguage();
        ((ILang1)pl).LangDetails();

        // calling the interface method 2
        ((ILang2)pl).LangDetails();

        // Another way of calling it
        ILang1 il1 = new ProgrammingLanguage();
        il1.LangDetails();
    }

}

// Creating the interface with the same method name
interface ILang1
{
    void LangDetails();
}

interface ILang2
{
    void LangDetails();
}

class ProgrammingLanguage : ILang1, ILang2
{
    // Hard to distinguish between the interface 1 method or interface 2 method
    /*  public void LangDetails()
        {
            Console.WriteLine("These is the language details");
        }*/

    // Implementing Interface Explicitly
    void ILang1.LangDetails()
    {
        Console.WriteLine("these is language 1 details method");
    }

    void ILang2.LangDetails()
    {
        Console.WriteLine("these is language 2 details method");
    }
}

