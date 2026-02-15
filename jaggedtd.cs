using System;

class Jaggedtd
{
    static void Main()
    {
        Console.Write("Enter number of dimensions: ");
        int dim = Convert.ToInt32(Console.ReadLine());

        int[][][] arr = new int[dim][][];

        for (int i = 0; i < dim; i++)
        {
            Console.Write("Enter number of Rows for dim " + i + ": ");
            int rows = Convert.ToInt32(Console.ReadLine());
            arr[i] = new int[rows][];

            for (int j = 0; j < rows; j++)
            {
                Console.Write("Enter number of columns for dim " + i + ", row " + j + ": ");
                int cols = Convert.ToInt32(Console.ReadLine());
                arr[i][j] = new int[cols];

                for (int k = 0; k < cols; k++)
                {
                    Console.Write("Enter element [" + i + "][" + j + "][" + k + "]: ");
                    arr[i][j][k] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        Console.WriteLine("\n3D Jagged array elements:");
        for (int i = 0; i < dim; i++)
        {
            Console.WriteLine("dim " + i + ":");
            for (int j = 0; j < arr[i].Length; j++)
            {
                for (int k = 0; k < arr[i][j].Length; k++)
                {
                    Console.Write(arr[i][j][k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}