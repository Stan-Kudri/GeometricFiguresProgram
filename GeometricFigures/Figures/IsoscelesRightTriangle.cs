﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigures;

namespace GeometricFigures.Figures
{
    public class IsoscelesRightTriangle : Primitive
    {
        public override string Name => "Isosceles Right Triangle";

        public override double Area => (A * B) / 2;

        public IsoscelesRightTriangle(int A, int B):base(A, B)
        {
        }

        public double Perimeter() => A + B + Hypotenuse;

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0}: Area = {1}; Perimetr = {2};", Name, Area, Perimeter());
            return stringBuilder.ToString();
        }

        private float Hypotenuse => (float)Math.Sqrt(A * A + B * B);
    }
}
