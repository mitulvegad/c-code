using System;
class arryindex
{
    static void Main()
    {
        int n, sum = 0;
        Console.Write("Enter size of : ");
        n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element at index " + i + ": ");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Index\tElement");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i + "\t" + a[i]);
            sum += a[i];
        }
        Console.WriteLine("sum of element: " + sum);
    }
}