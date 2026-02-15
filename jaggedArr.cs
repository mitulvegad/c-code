using System;

class JaggedArr
{
    static void Main()
    {
        int[][] arr = new int[4][];

        arr[0] = new int[2];
        arr[1] = new int[3];
        arr[2] = new int[1];
        arr[3] = new int[4];

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write("Enter value for arr[" + i + "][" + j + "]: ");
                arr[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Row " + i + " (Column: " + arr[i].Length + ")");
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.WriteLine("arr[" + i + "][" + j + "] = " + arr[i][j]);
            }
            Console.WriteLine();
        }
    }
}