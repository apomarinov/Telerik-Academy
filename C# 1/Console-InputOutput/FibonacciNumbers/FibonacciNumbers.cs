using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        private static int n;
        private static double[] numbers;


        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            ReadN();
            PrintFibonacciNumbers();
        }

        static void ReadN()
        {
            string input;

            Console.Write("Enter n: ");
            input = Console.ReadLine();

            int.TryParse(input, out n);
        }

        static void PrintFibonacciNumbers()
        {
            string numbers = "";

            for (int i = 0; i < n; i++)
            {
                if (i > 1)
                {
                    numbers += ", " + (i - 2 + i - 1);
                }
                else
                {
                    numbers += ", " + i;
                }
                
            }

            Console.WriteLine(numbers);
        }
    }
}
