using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask {
    class Сylinder:Circle {
        private double height;
        public double Height {
            get { return height; }
            set {
                if( value <= 0 ) {
                    Console.WriteLine( "height must be positive!" );
                }
                height = value;
            }
        }

        public Сylinder () { }

        public Сylinder ( double height ) 
            {
                this.Height = height;
            }
        public override void Print () {
            Console.WriteLine( "Сylinder:" );
            base.Print();
            Console.WriteLine( $"Radius:{R}" );
            Console.WriteLine( $"Height:{Height}" );
        }
        public double objem() {
            double objem = 3.14 * R * R * Height;
            return objem;
        }

        public override double Area () {
            double Sf = 2 * 3.14 * R * ( Height + R );
            return Sf;
        }
      
    }
}
