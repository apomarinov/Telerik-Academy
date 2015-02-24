using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNNumbers
{
    class PrintNNumbers
    {
        static void Main(string[] args)
        {
            string input;
            int n;

            Console.Write("Enter a positive number: ");
            input = Console.ReadLine();
            int.TryParse(input, out n);

            if (n > 0)
            {
                PrintOneToN(n);
            }
            else
            {
                Console.WriteLine("\"n\" must be positive.");
            }
        }

        static void PrintOneToN(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}
