using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures.Figures
{
    public class Circle: Primitive
    {
        private int _a;
        private int _b;
        private float _radius;

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
                return Math.PI * _radius * _radius;
            }           
        }

        public Circle(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public double Perimeter()
        {
            DefineRadius();
            return 2 * Math.PI * _radius;            
        }

        private void DefineRadius()
        {
            if (_a <= 0 || _b <= 0)
                throw new ArgumentException("Parameters are invalid");
            if (_a > _b || _a == _b)
                _radius = _b / 2;
            else
                _radius = _a / 2;
        }
    }
}
