using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures.Figures
{
    class Circle: Primitive
    {
        private float _radius;

        public int a => A;
        public int b => B;

        public override string Name 
        {
            get { return "Circle"; }
        }
        
        public override double Area
        {
            get 
            {
                DefineRadius();
                return Math.PI * _radius * _radius;
            }           
        }

        public Circle(int a, int b):base ( a, b )
        {
            
        }

        public double Perimeter()
        {
            DefineRadius();
            return 2 * Math.PI * _radius;            
        }

        private void DefineRadius()
        {
            if (A <= 0 || B <= 0)
                throw new ArgumentException("Parameters are invalid");
            if (A > B || A == B)
                _radius = B / 2;
            if(B > A)
                _radius = A / 2;
        }
    }
}
