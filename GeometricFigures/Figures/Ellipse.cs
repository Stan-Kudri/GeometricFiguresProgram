using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures.Figures
{
    public class Ellipse : Primitive
    {
        private int _a;
        private int _b;
        private float _largerRadius;
        private float _smallerRadius;

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
            get { return "Circle"; }
        }

        public double Area
        {
            get
            {
                DefineRadius();
                return Math.PI * _largerRadius * _smallerRadius;
            }
        }

        public Ellipse(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public double SummRadius()
        {
            DefineRadius();
            return _largerRadius + _smallerRadius;
        }

        private void DefineRadius()
        {
            if (_a <= 0 || _b <= 0)
                throw new ArgumentException("Parameters are invalid");
            if (_a == _b)
                _largerRadius = _smallerRadius = _a;
            if (_a > _b)
            {
                _largerRadius = _a;
                _smallerRadius = _b;
            }
            else
            {
                _largerRadius = _b;
                _smallerRadius = _a;
            }
        }
    }
}
