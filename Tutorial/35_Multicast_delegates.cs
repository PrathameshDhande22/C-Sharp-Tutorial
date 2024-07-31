using System;
class _35_Multicast_Delegates
{
    //  delegate function
    public delegate void MultiDelegate(int no);


    static void Main(string[] args)
    {
        MultiDelegate del1, del2, del3, del4;
        del1 = new MultiDelegate(MethodOne);
        del2 = new MultiDelegate(MethodTwo);
        del3 = new MultiDelegate(MethodThree);
        // Multicasting the delegate method of different instances
        del4 = del1 + del2 + del3 - del1;



        Console.WriteLine("Multi-Instance Delegate");

        // Calling the delegates;
        del4(45);


        Console.WriteLine("Single Instance Delegate");
        // Single Instance Multicasting Delegates
        MultiDelegate dd1 = new MultiDelegate(MethodOne);

        // Registering the Functions
        dd1 += MethodTwo;

        dd1 += MethodThree;

        // Calling the Delegates
        dd1(123);

        // Unregistering the Functions
        dd1 -= MethodTwo; // These method will not be called now
        dd1(455);



    }

    // Delegate method one
    public static void MethodOne(int no)
    {
        Console.WriteLine("Delegate Method one {0}", no);
    }

    // Delegate method two
    public static void MethodTwo(int no)
    {
        Console.WriteLine("Delegate Method two {0}", no);
    }

    // Delegate method three
    public static void MethodThree(int no)
    {
        Console.WriteLine("Delegate Method three {0}", no);
    }
}


