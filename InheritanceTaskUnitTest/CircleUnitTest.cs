
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceTask;
using System;

namespace InheritanceTaskUnitTest {
    [TestClass]
    public class CircleUnitTest {
        [TestMethod]
        public void AreaTestMethod () {
            Circle figure = new Circle( Colour.Blue, Colour.Green, 1, 3 );
            double expected = 28.27;
            double actual = figure.Area();
            Assert.AreEqual( expected, Math.Round( actual, 2 ) );
        }
        [TestMethod]
        public void PerimeterTestMethod () {
            Circle figure = new Circle( Colour.Blue, Colour.Green, 1, 3 );
            double expected = 18.85;
            double actual = figure.Perimeter();
            Assert.AreEqual( expected, Math.Round( actual, 2 ) );
        }
    }
}
