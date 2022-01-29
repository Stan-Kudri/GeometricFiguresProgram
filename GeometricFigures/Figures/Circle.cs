using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures.Figures
{
    public class Circle: Primitive
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

        public override string Name => "Circle";

        public override double Area
        {
            get 
            {
                var radius = Radius();
                return Math.PI * radius * radius;
            }
        }

        public Circle(int a, int b) : base(a, b)
        {

        }

        public double Perimeter()
        {
            var radius = Radius();
            return 2 * Math.PI * radius;            
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name).Append(";").
                Append($"Area = {Area}").Append(";").
                Append($"Perimetr = {Perimeter()}").Append(";");
            return stringBuilder.ToString();
        }

        private float Radius() => B > A ? (float)A / 2 : (float)B / 2;
    }
}
