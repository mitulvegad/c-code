using System;

class threedarray
{
    static void Main()
    {
        Console.Write("Enter dimension size: ");
        int d = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter row size: ");
        int r = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter column size: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int[,,] a = new int[d, r, c];

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                for (int k = 0; k < a.GetLength(2); k++)
                {
                    Console.Write("a[" + i + "," + j + "," + k + "]: ");
                    a[i, j, k] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                for (int k = 0; k < a.GetLength(2); k++)
                {
                    Console.Write("a[" + i + "," + j + "," + k + "]=" + a[i, j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}