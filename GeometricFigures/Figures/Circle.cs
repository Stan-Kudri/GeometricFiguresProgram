using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures.Figures
{
    public class Circle: Primitive
    {
        public override string Name => "Circle";

        public override double Area => Math.PI * Radius * Radius;

        private float Radius => B > A ? (float)A / 2 : (float)B / 2;

        public Circle(int a, int b) : base(a, b)
        {

        }

        public double Perimeter() => 2 * Math.PI * Radius;

        public override string ToString() => string.Format("{0}: Area = {1}; Perimetr = {2};", Name, Area, Perimeter());

    }
}
