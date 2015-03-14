using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideCircleAndOutsideOfRectangle
{
    class PointInsideCircleAndOutsideOfRectangle
    {
        static void Main(string[] args)
        {
            IsPointInCircleAndOutOfRectangle(1, 2);
            IsPointInCircleAndOutOfRectangle(2.5f, 2f);
            IsPointInCircleAndOutOfRectangle(0, 1);
            IsPointInCircleAndOutOfRectangle(2.5f, 1);
            IsPointInCircleAndOutOfRectangle(2, 0);
            IsPointInCircleAndOutOfRectangle(4, 0);
            IsPointInCircleAndOutOfRectangle(2.5f, 1.5f);
            IsPointInCircleAndOutOfRectangle(2, 1.5f);
            IsPointInCircleAndOutOfRectangle(1, 2.5f);
            IsPointInCircleAndOutOfRectangle(-100, -100);

        }

        static void IsPointInCircleAndOutOfRectangle(float pointX, float pointY)
        {
            float centerX = 1f,
                  centerY = 1f,
                  radius = 1.5f;
            float topX = -1f,
                  topY = 1f,
                  width = 6f,
                  height = 2f;

            bool isInCircle, isInRect;


            isInCircle = Math.Pow((pointX - centerX), 2) + Math.Pow((pointY - centerY), 2) <= radius * radius;

            bool isInX = pointX >= topX && pointX <= topX + width,
                 isInY = pointY <= topY && pointY <= topY + height;
            isInRect = isInX && isInY;

            Console.WriteLine(isInCircle && !isInRect);
        }
    }
}
