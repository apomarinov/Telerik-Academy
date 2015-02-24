using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            TrapezoidArea(5, 7, 12);
            TrapezoidArea(2, 1, 33);
            TrapezoidArea(8.5f, 4.3f, 2.7f);
            TrapezoidArea(100, 200, 300);
            TrapezoidArea(0.222f, 0.333f, 0.555f);
        }

        static void TrapezoidArea(float sideA, float sideB, float height)
        {
            float area = ((sideA + sideB) / 2f) * height;
            Console.WriteLine("Area: " + area);
        }
    }
}
