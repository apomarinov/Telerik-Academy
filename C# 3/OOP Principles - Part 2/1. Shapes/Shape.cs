using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        protected double width;
        protected double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double Width
        {
            get;
            set;
        }

        public abstract double Height
        {
            get;
            set;
        }

        public abstract double CalculateSurface();
    }
}
