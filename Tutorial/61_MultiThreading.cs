using System;
using System.Threading;
class _61_MultiThreading
{
    static void Main(string[] args)
    {
        // Running Multiple Threads
        Thread thr1 = new Thread(DoComputingTask);
        Thread thr2 = new Thread(DoComputingTask2);
        Thread thr3 = new Thread(DoComputingTask3);

        thr1.Start();
        thr1.Join();

        thr2.Start();
        thr2.Join();

        thr3.Start();
    }

    public static void DoComputingTask()
    {
        for (int i = 0; i < 50; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thread 1 with i={0}", i);
        }
    }

    public static void DoComputingTask2()
    {
        for (int i = 0; i < 50; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thread 2 with i={0}", i);
        }
    }

    public static void DoComputingTask3()
    {
        for (int i = 0; i < 50; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thread 3 with i={0}", i);
        }
    }
}

