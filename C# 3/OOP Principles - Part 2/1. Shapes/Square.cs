using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {
        public Square(double width, double height)
            :base(width, height)
        {
            if (width != height)
            {
                throw new ArgumentException("Width must equal Height");
            }
        }

        public override double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Width");
                }

                this.width = value;
            }
        }

        public override double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Height");
                }

                this.height = value;
            }
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
