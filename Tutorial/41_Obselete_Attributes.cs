using System;
class _41_Obselete_Attributes
{
    // Attributes Tutorial
    static void Main(string[] args)
    {
        SuperComputer sps=new SuperComputer();

        //Console.WriteLine(sps.SuperComputerFetch()); //  Throws Error due to deprecation
        Console.WriteLine(sps.SuperComputerFetch("AMD"));
    }
}


class SuperComputer
{
    // Declaring a method as deprecated using obselete Attributes to throw error to stop using these method
    [Obsolete("Please use SuperComputerFetch(string processor) instead",true)]
    public string SuperComputerFetch()
    {
        return "These is Super Computer with Intel i5";
    }



    public string SuperComputerFetch(string Processor)
    {
        return $"Super Computer with {Processor}";
    }
}

