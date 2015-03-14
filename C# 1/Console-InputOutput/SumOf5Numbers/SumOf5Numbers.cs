using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        private static double[] numbers = new double[5];

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            ReadNumbers();
            PrintSum();
        }

        static void ReadNumbers()
        {
            string input;
            string[] numbersAsString;

            Console.WriteLine("Enter numbers seperated by an interval: ");
            input = Console.ReadLine();
            numbersAsString = input.Split(' ');

            double.TryParse(numbersAsString[0], out numbers[0]);
            double.TryParse(numbersAsString[1], out numbers[1]);
            double.TryParse(numbersAsString[2], out numbers[2]);
            double.TryParse(numbersAsString[3], out numbers[3]);
            double.TryParse(numbersAsString[4], out numbers[4]);
        }

        static void PrintSum()
        {
            double sum = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];
            Console.WriteLine("Sum: " + sum);
        }
    }
}
