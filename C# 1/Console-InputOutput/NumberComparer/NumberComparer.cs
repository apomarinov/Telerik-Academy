using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double a, b;
            string input;

            Console.Write("Enter a: ");
            input = Console.ReadLine();
            double.TryParse(input, out a);

            Console.Write("Enter b: ");
            input = Console.ReadLine();
            double.TryParse(input, out b);

            Console.WriteLine(GetMax(a, b));
        }

        static double GetMax(double a, double b)
        {
            double max = (Math.Sqrt(a * a + b * b - 2 * a * b) + a + b) / 2;

            return max;
        }
    }
}
