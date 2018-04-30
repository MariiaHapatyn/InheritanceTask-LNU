using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask {
    public class Circle:Figure
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set 
            {
                if(value < 0)
                {
                    throw new ArgumentException("Radius must be positive!");
                }
                radius = value;
            }
        }

        public Circle (Colour cc = Colour.Black, Colour fc = Colour.Black, double cw = 0.0, double r = 0.0) : base(cc, fc, cw)
        {
            Radius = r;
        }

        public override void Print ()
        {
            Console.WriteLine("Circle: ");
            base.Print();
            Console.WriteLine($"Radius : {Radius}, Area : {Area()}, Perimeter : {Perimeter()}");
        }

        public override double Area () {
            double result = Math.PI * Radius * Radius;
            return result;
        }

        public override double Perimeter() {
            double result = Math.PI * 2 * Radius;
            return result;
        }
    }
}
