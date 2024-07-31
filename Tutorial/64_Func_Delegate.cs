using System;
class _64_Func_Delegate
    {
    static void Main(string[] args)
    {
        // Func Delegate with two input parameter as int and output parameter as int
        Func<int, int, int> Add = (no1, no2) => no1 + no2;

        Console.WriteLine(Add(2,3));

        // Func Delegate with two input parameter as string and int as ouput parameter
        Func<string,string,int> CompareString=(s1,s2)=>s1.CompareTo(s2);

        Console.WriteLine(CompareString("a","b"));

    }
}

