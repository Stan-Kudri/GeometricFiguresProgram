using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures.Figures
{
    public class Square : Primitive
    {
        private int _a;
        private int _b;
        private double _minimumSide;

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
            get { return "Square"; }
        }

        public double Area
        {
            get
            {
                DefinitionMinimumSide();
                return Math.Pow(_minimumSide, 2);
            }
        }
        public Square(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public double Diagonal()
        {
            DefinitionMinimumSide();
            return Math.Sqrt(_a * _a + _b * _b);
        }

        private void DefinitionMinimumSide()
        {
            if (_a <= 0 || _b <= 0)
                throw new ArgumentException("Parameters are invalid");
            if (_a <= _b)
                _minimumSide = _a;
            else
                _minimumSide = _b;
        }
    }
}
