using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask {
    public class Parallelepiped:Rectangle
    {
        public double Height
        {
            get { return Height; }
            set
            {
                if( value <= 0 )
                {
                    throw new ArgumentException("Height must be positive!");
                }
                Height = value;
            }
        }

        public Parallelepiped(Colour cc = Colour.Black, Colour fc = Colour.Black, double cw = 0.0, double w = 0.0, double l = 0.0, double h = 0.0) : base(cc, fc, cw, w, l)
        {
                Height = h;
        }

        public override void Print()
        {
            Console.WriteLine( "Parallelepiped: ");
            base.Print();
            Console.WriteLine( $"Height : {Height}");
        }

        public double Volume()
        {
            double result = Height * Width * Length;
            return result;
        }

        public override double Area()
        {
            double result = 2 * (Height * Width + Width * Length + Height * Length );
            return result;
        }
    }
}
