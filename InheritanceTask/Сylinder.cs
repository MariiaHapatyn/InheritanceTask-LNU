using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask {
    public class Сylinder:Circle
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
        
        public Сylinder(Colour cc = Colour.Black, Colour fc = Colour.Black, double cw = 0.0, double r = 0.0, double h = 0.0) : base(cc, fc, cw, r)
        {
            Height = h;
        }

        public override void Print()
        {
            Console.WriteLine("Сylinder: ");
            base.Print();
            Console.WriteLine( $"Height : {Height}");
        }

        public double Volume()
        {
            double result = Math.PI * Radius * Radius * Height;
            return result;
        }

        public override double Area()
        {
            double result = 2 * Math.PI * Radius * ( Height + Radius);
            return result;
        }
      
    }
}
