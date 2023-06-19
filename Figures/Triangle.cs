using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWorkMB.Figures
{
    public class Triangle : Figure
    {
        private const double delta = 1e-5;
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public bool IsRight { get; private set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException(null, "Any side of a triangle must be positive");
            }

            if (a + b < c || b + c < a || a + c < b)
            {
                throw new ArgumentException(null, "The sum of lengths of any two sides should be greater than the length of third side");
            }

            A = a;
            B = b;
            C = c;
            IsRight = isRightTriangle();
        }

        private bool isRightTriangle()
        {
            double max;
            if (A > B) max = A;
            else max = B;
            if (max < C) max = C;

            var error = 2 * max * max - A * A + B * B + C * C;
            return Math.Abs(error) < delta;

        }

        public override double Shape()
        {
            double shape;

            if (IsRight)
            {
                shape = A * B / 2;
            }
            else
            {
                var p = (A + B + C) / 2;
                shape = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }

            return shape;
        }
    }
}