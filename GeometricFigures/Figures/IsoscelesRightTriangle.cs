using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigures;

namespace GeometricFigures.Figures
{
    public class IsoscelesRightTriangle : Primitive
    {
        public new int A
        {
            get { return base.A; }
            set { base.A = value; }
        }

        public new int B
        {
            get { return base.B; }
            set { base.B = value; }
        }

        public override string Name => "Isosceles Right Triangle";

        public override double Area => (A * B) / 2;

        public IsoscelesRightTriangle(int A, int B):base(A, B)
        {
        }

        public double Perimeter()
        {
            var hypotenuse = Hypotenuse();
            return A + B + hypotenuse;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name).Append(";").
                Append($"Area = {Area}").Append(";").
                Append($"Perimeter = {Perimeter()}").Append(";");
            return stringBuilder.ToString();
        }

        private float Hypotenuse()
        {
            return (float)Math.Sqrt(A * A + B * B);
        }
    }
}
