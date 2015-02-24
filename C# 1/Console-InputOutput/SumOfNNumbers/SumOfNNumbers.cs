using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        private static int n;
        private static double[] numbers;


        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            ReadN();
            ReadNumbers();
            PrintSum();
        }

        static void ReadN()
        {
            string input;

            Console.Write("Enter n: ");
            input = Console.ReadLine();

            int.TryParse(input, out n);
        }

        static void ReadNumbers()
        {
            string input;
            
            numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                input = Console.ReadLine();
                double.TryParse(input, out numbers[i]);
            }
        }

        static void PrintSum()
        {
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}
