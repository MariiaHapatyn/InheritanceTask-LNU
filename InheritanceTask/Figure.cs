using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask {
    public enum Colour {
        Black,
        White,
        Green,
        Yellow,
        Red,
        Pink,
        Blue
    }
    public abstract class Figure
    {
        public Colour ContourColour { get; set; }
        public Colour FillingColour { get; set; }

        public double ContourWidth
        {
            get
            {
                return ContourWidth;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Contour width can't be negative!");
                }
                ContourWidth = value;
            }
        }

        protected Figure(Colour cc = Colour.Black, Colour fc = Colour.Black, double cw = 0.0)
        {
            ContourColour = cc;
            FillingColour = fc;
            ContourWidth = cw;
        }
        
        public virtual void Print()
        {
            Console.WriteLine( $"ContourWidth : {ContourWidth}, ContourColour : {ContourColour}, FillingColour : {FillingColour}");
        }
        
        public abstract double Perimeter ();
        public abstract double Area ();
    }
}

