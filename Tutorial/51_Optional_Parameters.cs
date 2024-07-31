using System;
using System.Runtime.InteropServices;
class _51_Optional_Parameters
{
    static void Main(string[] args)
    {
        // Calling the method by using only first two arguments
        StringConcat("String1", "String2");
        // Calling the method by passing the parameter arguments
        StringConcat("String1", "String2", "String3", "String4", "String5");


        // Calling the method by using the first two arguments
        AddNumbers(5, 5);
        // Calling the method by passing the arrays
        AddNumbers(5, 5, new int[] { 1, 2, 3, 4 });

        // Calling the method by using the first two arguments
        PrintNumbers(10, 20);
        // Calling the method by passing the parameter arguments
        PrintNumbers(19, 18, new int[] { 17, 16, 15, 14 });

        // Calling the method by using the first argument only
        SumofArrays(new int[] { 1, 2, 3, 4 });
        // Calling the method by passing the argument to the optional
        SumofArrays(new int[] { 1, 2, 3, 4 }, new int[] { 5, 10, 15 });
    }

    // Optional Parameter using parameter arrays
    public static void StringConcat(string s1, string s2, params string[] strs)
    {
        string result = s1 + " " + s2;
        if (strs != null)
        {
            foreach (string str in strs)
            {
                result += " " + str;
            }
        }
        Console.WriteLine(result);
    }

    // Optional Parameter using Method Overloading
    public static void AddNumbers(int first, int second)
    {
        AddNumbers(first, second, null);
    }

    public static void AddNumbers(int first, int second, int[] nums)
    {
        int result = first + second;
        if (nums != null)
        {
            foreach (int i in nums)
            {
                result += i;
            }
        }
        Console.WriteLine("The Sum is : {0}", result);
    }

    // Optional Parameter by using Optional Parameter
    public static void PrintNumbers(int first, int second, int[] nums = null)
    {

        Console.Write(first + " " + second + " ");
        if (nums != null)
        {
            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    // Optional Parameter by using Optional Attribute
    public static void SumofArrays(int[] nums, [Optional] int[] nums2)
    {
        int res = 0;
        foreach (int i in nums)
        {
            res += i;
        }
        if (nums2 != null)
        {
            foreach (int i in nums2)
            {
                res += i;
            }
        }
        Console.WriteLine("Sum of Arrays are : {0}", res);
    }
}

