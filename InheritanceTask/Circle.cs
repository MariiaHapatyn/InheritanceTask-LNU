using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask {
    class Circle:Figure {
        private double r;

        public double R
        {
            get { return r; }
            set 
            {
                if( value < 0 )
                    {
                        Console.WriteLine( "Radius must be positive!" );
                    }
                  r = value;
            }
       }
        
        public Circle () {  }

        public Circle ( double r ) {
            this.R = r;
        }
        public override void Print () {
            Console.WriteLine( "Circle:" );
           // base.Print();
            Console.WriteLine( $"Radius :{R}"  );
        }

        public override double Area () {
            double result = 3.14 * R * R;
            return result;
        }
        public override double Perimeter() {
            double result = 3.14 * 2 * R;
            return result;
        }
    }
}
