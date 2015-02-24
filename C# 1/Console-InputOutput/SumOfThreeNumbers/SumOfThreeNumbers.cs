using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;


namespace SumOfThreeNumbers
{
    class SumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            float a, b, c;

            Console.WriteLine("Enter a:");
            a = ReadFloat();

            Console.WriteLine("Enter b:");
            b = ReadFloat();

            Console.WriteLine("Enter c:");
            c = ReadFloat();

            Console.WriteLine("Sum: {0}", a + b + c);
        }

        static float ReadFloat()
        {
            string input;
            float num;

            input = Console.ReadLine();
            float.TryParse(input, out num);

            return num;
        }
    }
}
