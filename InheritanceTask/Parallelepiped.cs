using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask {
    class Parallelepiped:Rectangle {
        private double length;
        public double Length {
            get { return length; }
            set {
                if( value <= 0 ) {
                    Console.WriteLine( "length must be positive!" );
                }
                length = value;
            }
        }

        public Parallelepiped () { }

        public Parallelepiped(double length ) 
            {
                this.Length = length;
            }
        public override void Print () {
            Console.WriteLine( "Parallelepiped:" );
            base.Print();
            Console.WriteLine( $"Length{Length}" );
            Console.WriteLine( $"Width:{Width}" );
            Console.WriteLine( $"Height:{Height}" );
        }
        public double objem () {
            double objem = Length * Width * Height;
            return objem;
        }
        public override double Area () {
            double area = 2 * ( Length * Width + Width * Height + Length * Height );
            return area;
        }

        }
}
