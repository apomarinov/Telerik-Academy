using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleInInterval
{
    class DivisibleInInterval
    {
        private static int a, b;
        static void Main(string[] args)
        {
            ReadInput();
            PrintOutput();
        }

        static void ReadInput()
        {
            string input;

            Console.Write("Enter a: ");
            input = Console.ReadLine();
            int.TryParse(input, out a);

            Console.Write("Enter b: ");
            input = Console.ReadLine();
            int.TryParse(input, out b);
        }

        static void PrintOutput()
        {
            int numbersCount = 0,
                lesser = a < b ? a : b,
                greater = a > b ? a : b;
            for (int i = lesser; i <= greater; i++)
            {
                if (i != 0 && i % 5 == 0)
                {
                    numbersCount++;
                }
            }

            Console.WriteLine("Numbers divisible by 5 without remainder: " + numbersCount);
        }
    }
}
