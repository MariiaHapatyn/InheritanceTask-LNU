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
        private double contourWidth;

        public Colour ContourColour { get; set; }
        public Colour FillingColour { get; set; }

        public double ContourWidth
        {
            get
            {
                return contourWidth;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Contour width can't be negative!");
                }
                contourWidth = value;
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
            Console.WriteLine( $" ContourWidth : {ContourWidth}\n ContourColour : {ContourColour}\n FillingColour : {FillingColour}");
        }
        
        public abstract double Perimeter ();
        public abstract double Area ();
    }
}

