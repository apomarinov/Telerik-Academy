using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        private static int a;
        private static double b, c;
        private static string aHex, aBin;

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            ReadInput();

            Console.WriteLine(BuildOutputString());
        }

        static void ReadInput()
        {
            string input;

            Console.Write("Enter a: ");
            input = Console.ReadLine();
            int.TryParse(input, out a);

            Console.Write("Enter b: ");
            input = Console.ReadLine();
            double.TryParse(input, out b);

            Console.Write("Enter c: ");
            input = Console.ReadLine();
            double.TryParse(input, out c);
        }

        static string BuildOutputString()
        {
            aHex = a.ToString("X");
            aBin = IntToBin(a);
            return String.Format("{0} |{1}| {2}|{3} |", aHex, aBin, FormatFloatingPoint(b, "n2"), FormatFloatingPoint(c, "n3"));
        }

        static string IntToBin(int num)
        {
            return Convert.ToString(num, 2).PadLeft(10, '0');
        }

        static string FormatFloatingPoint(double num, string format)
        {
            int numNoDecimal = (int) Math.Truncate(num);
            double decimalPart = num - numNoDecimal;

            return decimalPart == 0 ? numNoDecimal.ToString() : num.ToString(format);
        }
    }
}
