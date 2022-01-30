using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures.Figures
{
    public class Ellipse : Primitive
    {
        public override string Name => "Ellipse";

        public override double Area => Math.PI * (A / 2) * (B / 2);

        public Ellipse(int a, int b) : base(a, b)
        {
        }

        public double SummRadius() => (A / 2) + (B / 2);

        public override string ToString() => string.Format("{0}: Area = {1}; Summ Radius = {2};", Name, Area, SummRadius());
    }
}
