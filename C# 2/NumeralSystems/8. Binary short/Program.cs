using System;

class Program
{
    static void Main()
    {
        short num;

        Console.Write("Enter a short number (-32768 to 32767): ");
        if (!short.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Invalid input");
            return;
        }
        Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0'));
    }
}