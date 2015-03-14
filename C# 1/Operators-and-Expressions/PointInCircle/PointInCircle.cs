using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            IsPointInCircle(1f, 0f);
            IsPointInCircle(-2f, 0f);
            IsPointInCircle(-1f, 2f);
            IsPointInCircle(1.5f, -1f);
            IsPointInCircle(-1.5f, -1.5f);
            IsPointInCircle(100f, -30f);
            IsPointInCircle(0f, 0f);
            IsPointInCircle(0.2f, -0.8f);
            IsPointInCircle(0.9f, -1.93f);
            IsPointInCircle(1f, 1.655f);
        }

        static void IsPointInCircle(float pointX, float pointY)
        {
            float centerX = 0f,
                  centerY = 0f,
                  radius = 2f;
            bool isInCircle;

            isInCircle = Math.Pow((pointX - centerX), 2) + Math.Pow((pointY - centerY), 2) <= radius * radius;

            Console.WriteLine(isInCircle);
        }
    }
}
