using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask {
    class Rectangle: Figure {
        private double width;
        private double height;
        public double Width {
            get { return width; }
            set {
                if( value <= 0 ) {
                    Console.WriteLine( "width must be positive!" );
                }
                width = value;
            }
        }
        public double Height {
            get { return height; }
            set {
                if( value <= 0 ) {
                    Console.WriteLine( "height must be positive!" );
                }
                height = value;
            }
        }

        public Rectangle() { }

        public Rectangle ( double width, double height ) {
            this.Width = width;
            this.Height = height;
        }
        //public override void Pouring ( Colour col ) {
        //   string result = "";

        //    switch( col ) {
        //        case Colour.Black:
        //            result = "black";
        //            break;
        //        case Colour.White:
        //            result = "White";
        //            break;
        //        case Colour.Green:
        //            result = "Green";
        //            break;
        //        case Colour.Yellow:
        //            result = "Yellow";
        //            break;
        //        case Colour.Red:
        //            result = "Red";
        //            break;
        //        case Colour.Pink:
        //            result = "Pink";
        //            break;
        //    }
        //    Console.WriteLine( "colour of figure is {0}", result );
        //}
        public override void Print () {
            Console.WriteLine( "Rectangle:" );
         //   base.Print();
            Console.WriteLine($"Width:{Width}" );
            Console.WriteLine($"Height:{Height}" );
        }
        public override double Perimeter () {
            double result = ( Width + Height) * 2;
            return result;
        }
        public override double Area () {
            double result = Width * Height;
            return result;
        }
    }
}
