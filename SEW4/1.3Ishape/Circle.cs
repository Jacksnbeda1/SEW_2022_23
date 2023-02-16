using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3Ishape
{
   
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            return  Math.PI * radius * radius;
        }
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }
    }
}
