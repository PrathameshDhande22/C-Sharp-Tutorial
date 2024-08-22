using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _71_Operator_Overloading
{



    static void Main(string[] args)
    {
        Matrix mat = new Matrix(new int[,] { { 1, 3 }, { 2, 4 } });
        Matrix mat2 = new Matrix(new int[,] { { 1, 4 }, { 1, 1 } });
        Matrix mat3 = mat + mat2;
        mat3.PrintMatrix();

    }

}

class Matrix
{
    public int[,] Arr { get; set; }
    public Matrix(int[,] arr)
    {
        Arr = arr;
    }

    public Matrix() { }

    public static Matrix operator +(Matrix mat1, Matrix mat2)
    {
        if (mat1.Arr.Length != mat2.Arr.Length)
        {
            throw new Exception("Both Matrix should be of same length");
        }
        int rows = mat1.Arr.GetLength(0);
        int cols = mat1.Arr.GetLength(1);
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = mat1.Arr[i, j] + mat2.Arr[i, j];
            }
        }
        return new Matrix(result);
    }

    public void PrintMatrix()
    {
        int rows = Arr.GetLength(0);
        int cols = Arr.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write(Arr[i, j] + " ");
            }
            Console.Write("]\n");
        }
    }


}

