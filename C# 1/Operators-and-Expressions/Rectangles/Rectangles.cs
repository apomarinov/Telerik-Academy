using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            rectInfo(3f, 4f);
            rectInfo(2.5f, 3f);
            rectInfo(5f, 5f);
        }

        static void rectInfo(float width, float height)
        {
            Console.WriteLine("\nArea: " + (width * height));
            Console.WriteLine("Perimeter: " + (width * 2 + height * 2));
        }
    }
}
