using System;

class _07_Arrays
{

    static void Main(string[] args)
    {
        // Arrays in C#

        // Defining the array
        int[] nos = new int[5];
        nos[1] = 0;
        nos[2] = 1;
        nos[3] = 3;
        Console.WriteLine(nos[3]);

        // Defining String Datatype Array.
        string[] names = { "Prathamesh", "Prashant", "Dhande", "Clever", "Prasad" };
        Console.WriteLine(names[2]);

        // Length of the string
        Console.WriteLine("Length of the array is:{0}", nos.Length);

        // the Dimensions of the Array
        Console.WriteLine("dimensions of the Array : {0}", nos.Rank);


        // 2D dimensional Array
        int[,] nos2 = new int[2, 2];

        // Storing Elements in 2D dimensional Array
        int[,] nos3 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 6, 7 } };

        // Dimensions of the 2D array

        Console.WriteLine("Dimension of the 2D Array : {0}", nos3.Rank);

    }

}