using System;
class _37_Inner_Exception
{
    static void Main(string[] args)
    {
        // outer Exception
        try
        {
            // Inner Exception
            try
            {
                // Throwing the exception implicitly
                throw new DllNotFoundException("Exception Thrown by me");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new DivideByZeroException("Division by Zero", e);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Outer Exception Type: {0}", ex.GetType().Name);
            // Null Condition Operator
            Console.WriteLine("Inner Exception type: {0}", ex.InnerException?.GetType().Name);
        }
    }

}

