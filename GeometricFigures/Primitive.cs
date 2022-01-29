using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public abstract class Primitive
    {
        private int _a;
        private int _b;

        public int A
        {
            get { return _a; }
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Parameter Greater than Zero");
                _a = value; 
            }
        }

        public int B
        {
            get { return _b; }
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Parameter Greater than Zero");
                _b = value; 
            }
        }

        public abstract double Area { get; }

        public abstract string Name { get; }

        public Primitive( int a, int b)
        {
            if (a <= 0 || b <= 0)
                throw new ArgumentException("Parameter Greater than Zero");
            _a = a;
            _b = b;
        }

    }
}
