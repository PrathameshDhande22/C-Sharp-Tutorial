using System;
class _44_Generics
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4 };
        string[] fruits = { "Apple", "Banana", "Orange", "Grapes" };
        PrintArray<int>(arr);
        PrintArray(fruits);

        Launch<String> ls = new Launch<string>("Prathamesh");
    }
    // Generics Method
    public static void PrintArray<T>(T[] arr)
    {
        foreach (T t in arr)
        {
            Console.WriteLine(t);
        }
    }
}

// Generics Classes
class Launch<T>
{
    T t;
    public Launch(T t)
    {
        this.t = t;
    }
}


