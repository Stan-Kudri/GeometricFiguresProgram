using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures.Figures
{
    public class IsoscelesRightTriangle : Primitive
    {
        private int _a;
        private int _b;
        private double _c;

        public int A
        {
            get { return _a; }
            set { _a = value; }
        }

        public int B
        {
            get { return _b; }
            set { _b = value; }
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
                return (_a * _b) / 2;
            }
        }
        public IsoscelesRightTriangle(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public double Perimeter()
        {
            DefinitionHypotenuse();
            return _a + _b + _c;
        }

        private void DefinitionHypotenuse()
        {
            if (_a <= 0 || _b <= 0)
                throw new ArgumentException("Parameters are invalid");
            _c = Math.Sqrt(_a * _a + _b * _b);
        }
    }
}
