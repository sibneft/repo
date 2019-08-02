using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateSquare
{
    

    public class Figure
    {
        private Type type;
        private double radius;
        private double a, b, c;
        public Figure(Type _type, double _radious)
        {
            type = _type;
            radius = _radious;
        }

        public Figure(Type _type, double _a, double _b, double _c)
        {
            type = _type;
            a = _a;
            b = _b;
            c = _c;
        }

        public Type GetTypeOfFigure()
        {
            if(type == Type.Circle)
            {
                return Type.Circle;
            }
            if(type == Type.Triangle)
            {
                return Type.Triangle;
            }
                return Type.Unknown;
        }

        public double CalculateSquare()
        {
            if (type == Type.Circle)
            {
                return Math.PI * Math.Pow(radius, 2);
            }
            if (type == Type.Triangle)
            {
                var p = 0.5 * (a + b + c);
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
            {
                throw new InvalidOperationException("The Figure is unknown");
            }
        }

        public bool IsRightTriangle()
        {
            if(type == Type.Triangle)
            {
                return (a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2))
                || b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2))
                || c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            }
            throw new InvalidOperationException("The Figure is not Triangle");
            
        }
    }


    
}
