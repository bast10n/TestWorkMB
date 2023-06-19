using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWorkMB.Figures;

namespace TestWorkMB
{
    public class CalculateArea
    {
        public double Shape(double radius)
        {
            var circle = new Circle(radius);
            return circle.Shape();
        }

        public double Shape(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            return triangle.Shape();
        }
    }
}