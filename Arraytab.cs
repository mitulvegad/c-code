using System;

class Arraytab
{
    static void Main()
    {
        Console.WriteLine("Enter row size:");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter column size:");
        int c = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[r, c];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("Enter arr [" + i + "," + j + "]: ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }


        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("arr[" + i + "," + j + "] = " + arr[i, j] + "\n");
            }
            Console.WriteLine();
        }
        
        Console.ReadLine();
    }
}