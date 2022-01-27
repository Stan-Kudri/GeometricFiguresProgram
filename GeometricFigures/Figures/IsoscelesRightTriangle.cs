using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigures;

namespace GeometricFigures.Figures
{
    /*class IsoscelesRightTriangle : Primitive
    {
        private double _c;

        public int A
        {
            get { return A; }
            set { A = value; }
        }

        public int B
        {
            get { return B; }
            set { B = value; }
        }

        public string Name
        {
            get { return "Isosceles Right Triangle"; }
        }

        public double Area
        {
            get
            {
                DefinitionHypotenuse();
                return (A * B) / 2;
            }
        }
        public IsoscelesRightTriangle(int A, int B):base(A, B)
        {
        }

        public double Perimeter()
        {
            DefinitionHypotenuse();
            return A + B + _c;
        }

        private void DefinitionHypotenuse()
        {
            if (A <= 0 || B <= 0)
                throw new ArgumentException("Parameters are invalid");
            _c = Math.Sqrt(A * A + B * B);
        }
    }*/
}
