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

        public Square(int A, int B) : base(A, B)
        {
        }

        public double Diagonal() => Math.Sqrt(A * A + B * B);

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0}: Area = {1}; Diagonal = {2};", Name, Area, Diagonal());
            return stringBuilder.ToString();
        }

        private int MinimumSide => A > B ? B : A;
    }
}
