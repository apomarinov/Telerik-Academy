using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        private static double a, b, c;
        private static double[] roots = new double[2];

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            ReadInput();
            PrintSolution();
        }

        static void ReadInput()
        {
            string input;

            Console.Write("Enter a: ");
            input = Console.ReadLine();
            double.TryParse(input, out a);

            Console.Write("Enter b: ");
            input = Console.ReadLine();
            double.TryParse(input, out b);

            Console.Write("Enter c: ");
            input = Console.ReadLine();
            double.TryParse(input, out c);
        }

        static void PrintSolution()
        {
            if (Evaluate())
            {
                PrintRoots();
            }
            else
            {
                Console.WriteLine("No Real Roots");
            }
        }

        static bool Evaluate()
        {
            double discriminant = Discriminant();
            if (discriminant < 0)
            {
                return false;
            }

            roots = GetRoots(discriminant);
            return true;
        }

        static double[] GetRoots(double discriminant)
        {
            double[] roots = new double[2];

            roots[0] = (-b - Math.Sqrt(discriminant)) / (2 * a);
            roots[1] = (-b + Math.Sqrt(discriminant)) / (2 * a);

            return roots;
        }

        static double Discriminant()
        {
            double d = b * b - 4 * a * c;

            return d;
        }

        static void PrintRoots()
        {
            Console.WriteLine("x1: " + roots[0].ToString("n2"));
            Console.WriteLine("x2: " + roots[1].ToString("n2"));
        }
    }
}
