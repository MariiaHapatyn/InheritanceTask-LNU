using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceTask;

namespace InheritanceTaskUnitTest {
    [TestClass]
    public class RectangleUnitTest {
        public void AreaTestMethod () {
            Rectangle figure = new Rectangle( Colour.Green, Colour.Pink, 0.1, 1.5, 2 );
            double expected = 6;
            double actual = figure.Area();
            Assert.AreEqual( expected, actual );
        }
        [TestMethod]
        public void PerimeterTestMethod () {
            Rectangle figure = new Rectangle( Colour.Green, Colour.Pink, 0.1, 1.5, 2 );
            double expected = 7;
            double actual = figure.Perimeter();
            Assert.AreEqual( expected, actual );
        }
    }
}
