using System;
class _26_Method_Overloading
{
    // Method Overloading

    static void Main(string[] args)
    {
        int res = Add(1, 2);
        float res2 = Add(1, 2, 3);
        int res4;
        int res3 = Add(1, 2, out res4);
        

        Console.WriteLine(res + " " + res2 + " " + res4+" "+res3);
    }


    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static float Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public static int Add(int a, int b, out int sum)
    {
        sum = a + b;
        return a;
    }
}
