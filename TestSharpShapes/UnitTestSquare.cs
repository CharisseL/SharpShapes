using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestSquare
    {
        [TestMethod]
        public void TestSquareConstructor()
        {
            Square square = new Square(50);
            Assert.AreEqual(50, square.Width);
            Assert.AreEqual(50, square.Height);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSanityChecksWidth()
        {
            Square square = new Square(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSanityChecksWidthPositivity()
        {
            Square square = new Square(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSanityChecksHeight()
        {
            Square square = new Square(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSanityChecksHeightPositivity()
        {
            Square square = new Square(-1);
        }

    }
}
