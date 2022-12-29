using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            
                int a = 3;
                int b = 5;
                int exp = 15;

                Geometry g = new Geometry();
                int actual = g.CalculateArea(a, b);
                Assert.AreEqual(exp, actual);
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            bool catched = false;
            try
            {
                int a = -4;
                int b = 10;
                

                Geometry g = new Geometry();
                g.CalculateArea(a, b);
                
            }
            catch (ArgumentException e)
            {
                catched = true;
            }
            Assert.IsTrue(catched, "не обработанные допустимые значения");
        }
        [TestMethod]
        public void TestMethod3()
        {
            int a = -4;
            int b = 10;
            Geometry g = new Geometry();
            Assert.ThrowsException<ArgumentException>(()=>g.CalculateArea(a, b),"не обработанные отрицательные стороны");
        }
    }
}
