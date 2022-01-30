using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures.Figures
{
    public class Square : Primitive
    {
        public override string Name => "Square";

        public override double Area => Math.Pow(MinimumSide, 2);

        private int MinimumSide => A > B ? B : A;

        public Square(int A, int B) : base(A, B)
        {
        }

        public double Diagonal() => Math.Sqrt(A * A + B * B);

        public override string ToString() => string.Format("{0}: Area = {1}; Diagonal = {2};", Name, Area, Diagonal());
    }
}
