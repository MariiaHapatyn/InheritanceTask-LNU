using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask {
    enum Colour {
        Black,
        White,
        Green,
        Yellow,
        Red,
        Pink,
        Blue
    }
    abstract class Figure {
        private double contourWidth;
        public double ContourWidth {
            get { return contourWidth; }
            set {
                if( value < 0 ) 
                {
                    Console.WriteLine( "Contour width can't be negative !" );
                }
                contourWidth = value;
            }
        }

        public abstract void Print ();
    //    {
    //    Console.WriteLine( $"ContourWidth : {ContourWidth}" );
    //}
   // public abstract Colour Pouring ( );
        public abstract double Perimeter ();
        public abstract double Area ();
    }
}
