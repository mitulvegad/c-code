using System;
class dynamic1
{
    static void Main()
    {
        dynamic a = 20;
        Console.WriteLine("Int: " + a);
        a = 12.5;
        Console.WriteLine("double: " + a);
        a = 'p';
        Console.WriteLine("Chur: " + a);
        a = "hi";
        Console.WriteLine("String " + a);
        Console.ReadLine();
    }
}