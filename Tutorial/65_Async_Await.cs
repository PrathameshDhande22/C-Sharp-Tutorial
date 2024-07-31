using System;
using System.Threading;
using System.Threading.Tasks;
class _65_Async_Await
{
    static void Main(string[] args)
    {
        Console.WriteLine(CalculateAnswer(3).Result);
        RunOther();
       
    }

    // 
    public static async Task<int> CalculateAnswer(int ans)
    {
        Console.WriteLine("Waiting for 2 min");
        Console.WriteLine("Executing other Codes");
        await Task.Delay(2000);
        return 1 + 1;
    }

    public static void RunOther()
    {
        for(int i = 0; i < 8; i++)
        {
            Console.WriteLine("Executing {0} times",i+1);
        }
    }
}
