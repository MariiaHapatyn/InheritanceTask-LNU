using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask {
    public class Rectangle: Figure
    {
        private double width;
        private double length;

        public double Width
        {
            get { return width; }
            set
            {
                if( value <= 0 )
                {
                    throw new ArgumentException("Width must be positive!");
                }
                width = value;
            }
        }

        public double Length
        {
            get { return length; }
            set
            {
                if( value <= 0 )
                {
                    throw new ArgumentException("Length must be positive!");
                }
                length = value;
            }
        }

        public Rectangle (Colour cc = Colour.Black, Colour fc = Colour.Black, double cw = 0.0, double w = 0.0, double l = 0.0) : base(cc, fc, cw)
        {
            Width = w;
            Length = l;
        }

        public override void Print ()
        {
            Console.WriteLine("Rectangle: ");
            base.Print();
            Console.WriteLine($" Width : {Width}\n Length : {Length}");
        }

        public override double Perimeter () {
            double result = (Width + Length) * 2;
            return result;
        }

        public override double Area () {
            double result = Width * Length;
            return result;
        }
    }
}
