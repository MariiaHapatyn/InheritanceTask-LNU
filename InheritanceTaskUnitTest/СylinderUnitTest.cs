using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceTask;
using System;

namespace InheritanceTaskUnitTest {
    
    [TestClass]
    public class СylinderUnitTest {
        public void AreaTestMethod () {
            Сylinder figure = new Сylinder( Colour.Black, Colour.Blue, 0.1, 1, 1 );
            double expected = 3.14;
            double actual = figure.Area();
            Assert.AreEqual( expected, Math.Round( actual, 2 ) );
        }
        [TestMethod]
        public void VolumeTestMethod () {
            Сylinder figure = new Сylinder( Colour.Black, Colour.Blue, 0.1, 1.3, 1.4 );
            double expected = 7.43;
            double actual = figure.Volume();
            Assert.AreEqual( expected, Math.Round( actual, 2 ) );
        }
    }
}
