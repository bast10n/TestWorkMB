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
        /// <summary>
        /// Calculating the area of a circle
        /// </summary>
        /// <param name="radius">positive number</param>
        /// <returns>area</returns>
        public double Shape(double radius)
        {
            var circle = new Circle(radius);
            return circle.Shape();
        }
        /// <summary>
        /// Calculating the area of a triangle
        /// </summary>
        /// <param name="a">cathetus positive number</param>
        /// <param name="b">cathetus positive number</param>
        /// <param name="c">hypotenuse positive number</param>
        /// <returns>area</returns>
        public double Shape(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            return triangle.Shape();
        }
    }
}