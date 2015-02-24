using System;

class Program
{
    static void Main()
    {
        int n, s;
        double p;

        n = int.Parse(Console.ReadLine());
        s = int.Parse(Console.ReadLine());
        p = double.Parse(Console.ReadLine());

        double a = (double)n * s;

        Console.Write("{0:F3}", a * p * 0.0025d);
    }
}