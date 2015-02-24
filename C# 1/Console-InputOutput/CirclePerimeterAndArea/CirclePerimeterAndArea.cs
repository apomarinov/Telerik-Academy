using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double radius, perimeter, area;
            string input;

            Console.WriteLine("Enter radius:");
            input = Console.ReadLine();
            double.TryParse(input, out radius);
            perimeter = 2 * Math.PI * radius;
            area = Math.PI * radius * radius;


            Console.WriteLine("Perimeter: {0:F2}, Area: {0:F2}", perimeter, area);
        }
    }
}
