using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceTask;

namespace InheritanceTaskUnitTest {
    [TestClass]
    public class ParallelepipedUnitTest {
        public void AreaTestMethod () {
            Parallelepiped figure =  new Parallelepiped( Colour.White, Colour.Yellow, 0.1, 1, 1, 1 );
            double expected = 6;
            double actual = figure.Area();
            Assert.AreEqual( expected, actual );
        }
        [TestMethod]
        public void VolumeTestMethod () {
            Parallelepiped figure = new Parallelepiped( Colour.White, Colour.Yellow, 0.1, 1.1, 1.6, 1.2 );
            double expected = 2.112;
            double actual = figure.Volume();
            Assert.AreEqual( expected, actual );
        }
    }
}
