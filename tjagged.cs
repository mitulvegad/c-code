using System;

class tJagged
{
    static void Main()
    {
        Console.Write("Enter number of Rows: ");
        int Rows = Convert.ToInt32(Console.ReadLine());

        int[][] arr = new int[Rows][];

        for (int i = 0; i < Rows; i++)
        {
            Console.Write("Enter number of column for Row " + i + ": ");
            int cols = Convert.ToInt32(Console.ReadLine());
            
            arr[i] = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                Console.Write("Enter element [" + i + "][" + j + "]: ");
                arr[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nJagged array elements: ");

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}