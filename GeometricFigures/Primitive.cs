using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    abstract class Primitive
    {
        protected int A;
        protected int B;

        public Primitive( int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        public abstract double Area
        {
            get;
        }

        public abstract string Name { get;}
    }
}
