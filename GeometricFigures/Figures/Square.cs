using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures.Figures
{
    public class Square : Primitive
    {
        public new int A
        {
            get { return base.A; }
            set 
            {
                base.A = value; 
            }
        }

        public new int B
        {
            get { return base.B; }
            set { base.B = value; }
        }

        public override string Name => "Square";

        public override double Area
        {
            get
            {
                var minSide = MinimumSide();
                return Math.Pow(minSide, 2);
            }
        }

        public Square(int A, int B) : base(A, B)
        {
        }

        public double Diagonal() => Math.Sqrt(A * A + B * B);

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name).Append(";").
                Append($"Area = {Area}").Append(";").
                Append($"Diagonal = {Diagonal()}").Append(";");
            return stringBuilder.ToString();
        }

        private int MinimumSide() => A > B ? B : A;
    }
}
