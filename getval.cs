using System;
class getval
{
    static void Main()
    {
        double number;

        Console.WriteLine("Enter a number (double value):");
        number = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("you Entered: " + number);
    }
}