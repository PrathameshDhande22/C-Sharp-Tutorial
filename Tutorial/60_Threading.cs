using System;
using System.Threading;
class _60_Threading
{
    static void Main(string[] args)
    {
        // Threading
        // Create a thread and passing the method to it.
        Thread thread = new Thread(DoComputingTask);

        // Starting a thread
        thread.Start();
        //DoComputingTask(); without thread these will block until these function completes its execution

        SimpleTask(); // These Function will run 

        // Passing the parameter to the method of a thread
        Thread thread2 = new Thread(DoComputingTaskParameters);
        // passing the argument for the method in start.
        thread2.Start(100);
    }

    public static void DoComputingTask()
    {
        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Computing Task : {0}", i);
        }
    }

    public static void SimpleTask()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void DoComputingTaskParameters(object till)
    {
        for (int i = 0; i < (int)till; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Computing Task with Parameter: {0}", i);
        }
    }
}

