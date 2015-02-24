using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double firstF = -4.999999d,
                  secondF = -4.999998d;
            double absFirstSecond, eps = 0.000001d;
            bool equal;

            absFirstSecond = Math.Abs(firstF - secondF);
            equal = absFirstSecond < eps;

            Console.WriteLine(equal);
        }
    }
}
