using System;
using System.Runtime.CompilerServices;

class _38_Custom_Exception
{

    static void Main(string[] args)
    {
        // Custom Exception
        try
        {
            throw new PaymentFailedException("Paytm failed");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.GetType().Name);
            Console.WriteLine(e);
            // Calling the overrided method
            Console.WriteLine(e.HelpLink);
        }
    }

}



// Custom Class Exception inherit the Exception class
class PaymentFailedException : Exception
{
    // Constructor
    public PaymentFailedException() : base() { }

    // Constructor with message 
    public PaymentFailedException(string message) : base(message) { }

    // Constructor with InnerException
    public PaymentFailedException(string message, Exception innerException) : base(message, innerException) { }

    // Overriding Exception Class Method
    public override string HelpLink { get => "https://www.google.com"; }

}