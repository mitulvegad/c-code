using System;

class demo
{
    static void Main()
    {
        Console.WriteLine("enter row size:");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter column size:");
        int c = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[r, c];

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write("Enter value for [" + i + "," + j + "]: ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nCounts");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                bool printed = false;

                for (int x = 0; x < r; x++)
                {
                    for (int y = 0; y < c; y++)
                    {
                        if (x == i && y == j) 
                        {
                            break; 
                        }
                        if (arr[i, j] == arr[x, y])
                        {
                            printed = true;
                            break;
                        }
                    }
                    if (printed) 
                    {
                        break;
                    }
                }

                if (printed == false)
                {
                    int count = 0;
                    for (int x = 0; x < r; x++)
                    {
                        for (int y = 0; y < c; y++)
                        {
                            if (arr[i, j] == arr[x, y])
                            {
                                count++;
                            }
                        }
                    }
                    Console.WriteLine("Element " + arr[i, j] + " is found " + count + " times");
                }
            }
        }
        Console.ReadLine();
    }
}