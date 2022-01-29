using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures.Figures
{
    public class Ellipse : Primitive
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

        public override string Name => "Ellipse";

        public override double Area => Math.PI * (A / 2) * (B / 2);

        public Ellipse(int a, int b) : base(a, b)
        {
        }

        public double SummRadius() => (A / 2) + (B / 2);

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name).Append(";").
                Append($"Area = {Area}").Append(";").
                Append($"Summ Radius = {SummRadius()}").Append(";");
            return stringBuilder.ToString();
        }
    }
}
