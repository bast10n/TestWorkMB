using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWorkMB.Figures
{
    class Circle : Figure
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException(nameof(radius), "Positive number required");
            Radius = radius;
        }

        public override double Shape()
        {
            double shape = Math.PI * (Radius * Radius);
            return Math.Round(shape, 3);
        }
    }
}