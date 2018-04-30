using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask {
  public  class Program {
        
        static void Main ( string[ ] args ) {

            List<Figure> figures = new List<Figure>();
            try
            {
                figures.Add(new Circle(Colour.Blue, Colour.Green, 1, 3));
                figures.Add(new Rectangle(Colour.Pink, Colour.Red, 0.1, 1.5, 1.4));
                figures.Add(new Parallelepiped(Colour.White, Colour.Yellow, 0.1, 1.1, 1.6, 1.2));
                figures.Add(new Сylinder(Colour.Black, Colour.Blue, 0.1, 1.3, 1.4));
                figures.Add(new Rectangle(Colour.Green, Colour.Pink, 0.1, 1.5, 1.7));
                Task.TotalPerimeter(figures);
                Task.TotalArea(figures);
                Console.WriteLine(" All figures: ");
                Task.PrintAllFigures(figures);
                }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }
    }
}
