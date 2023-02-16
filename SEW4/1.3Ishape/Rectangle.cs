using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3Ishape
{

    public class Rectangle : IShape

    {
       

        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double CalculateArea()
        {
            return length * width;
        }
        public double CalculateCircumference()
        {
            return 2 * (length + width);
        }
    }
}