using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceTask;
using System.Collections.Generic;

namespace InheritanceTaskUnitTests {
    [TestClass]
    public class TaskUnitTest {
        [TestMethod]
        public void TotalAreaTestMethod () {
            List<Figure> figures = new List<Figure>();

            figures.Add( new Circle( Colour.Blue, Colour.Green, 1, 3 ) );
            figures.Add( new Rectangle( Colour.Pink, Colour.Red, 0.1, 1.5, 1.4 ) );

            double expected = 30.37;
            double actual = Task.TotalArea( figures );
            Assert.AreEqual(expected, Math.Round( actual, 2 ));
        }
        [TestMethod]
        public void TotalPerimeterTestMethod () {
            List<Figure> figures = new List<Figure>();

            figures.Add( new Circle( Colour.Blue, Colour.Green, 1, 3 ) );
            figures.Add( new Сylinder( Colour.Black, Colour.Blue, 0.1, 1.3, 1.4 ) );
            figures.Add( new Rectangle( Colour.Green, Colour.Pink, 0.1, 1.5, 1.7 ) );

            double expected = 33.42;
            double actual = Task.TotalPerimeter( figures );
            Assert.AreEqual( expected, Math.Round( actual, 2 ) );
        }
    }
}
