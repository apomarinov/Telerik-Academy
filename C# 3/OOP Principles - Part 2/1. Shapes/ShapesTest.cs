using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Shapes;

class ShapesTest
{
    static void Main()
    {
        Shape[] shapes = new Shape[] { 
            new Square(5, 5),
            new Rectangle(34.2, 22.5),
            new Triangle(2, 6)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Type: {0}, Surface: {1}", shape.GetType(), shape.CalculateSurface());
        }
    }
}