using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask {
   public class Task {

        public static double TotalArea ( List<Figure> list ) {
            double result = 0;
            for( int i = 0; i < list.Count; i++ ) {
                result += list[i].Area();
            }
            Console.WriteLine($"Total Area  is : {result}" );
            return result;
        }

        public static double TotalPerimeter ( List<Figure> list ) {
            double result = 0;
            for( int i = 0; i < list.Count; i++ ) {
                result += list[i].Perimeter();
            }
            Console.WriteLine( $"Total Perimeter  is : {result}" );
            return result;
        }

        public static void PrintAllFigures(List<Figure> figures)
        {
            foreach(var figure in figures)
            {
                figure.Print();
            }
        }
    }
}
