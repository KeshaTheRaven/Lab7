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

    [TestClass]
    public class Simvol
    {
        [TestMethod]
        public void SymvolTest1()
        {
            int n = 5;
            string expected = "ABCDE";
            MathTaskClassLibrary.Simvol str = new MathTaskClassLibrary.Simvol();
            string actual = str.Write(n);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SymvolTest2()
        {
            bool cathed = false;
            try
            {
                int n = 27;
                MathTaskClassLibrary.Simvol str = new MathTaskClassLibrary.Simvol();
                string actual = str.Write(n);
            }
            catch (ArgumentException)
            {
                cathed = true;
            }

            Assert.IsTrue(cathed, "АргументЭксэпшн");
        }
        [TestMethod]
        public void SymvolTest3()
        {
            bool cathed = false;
            try
            {
                int n = 0;
                MathTaskClassLibrary.Simvol str = new MathTaskClassLibrary.Simvol();
                string actual = str.Write(n);
            }
            catch (ArgumentException)
            {
                cathed = true;
            }

            Assert.IsTrue(cathed, "АргументЭксэпшн");
        }
    }

    [TestClass]
    public class Quad
    {
        [TestMethod]
        public void QuadTest1()
        {
            double a = 1, b = 1, c = 1;
            var eq = new MathTaskClassLibrary.Quad(a, b, c);
            double[] actual = eq.Solution();
            double[] expected = new double[0];
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void QuadTest2()
        {
            //1 тест ?
            bool cathed = false;
            try
            {
                double a = 0, b = 1, c = 1;
                var eq = new MathTaskClassLibrary.Quad(a, b, c);
                double[] actual = eq.Solution();
                double[] expected = { };
            }
            catch
            {
                cathed = true;
            }
            Assert.IsTrue(cathed);
        }
        [TestMethod]
        public void QuadTest3()
        {
            double a = 1, b = -6, c = 9;
            var eq = new MathTaskClassLibrary.Quad(a, b, c);
            double[] actual = eq.Solution();
            double[] expected = { 3 };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void QuadTest4()
        {
            double a = 1, b = 4, c = 3;
            var eq = new MathTaskClassLibrary.Quad(a, b, c);
            double[] actual = eq.Solution();
            double[] expected = { -1, -3 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class VisicosTest
    {
        [TestMethod]
        public void Year1()
        {
            int year = 300;
            Visokos v = new Visokos(year);
            int actual = v.NumDays(year);
            int expected = 365;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Year2()
        {
            int year = 1200;
            Visokos v = new Visokos(year);
            int actual = v.NumDays(year);
            int expected = 366;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Year3()
        {
            bool cathed = false;
            try
            {
                int year = 0;
                Visokos v = new Visokos(year);
                int actual = v.NumDays(year);
            }
            catch (ArgumentException)
            {
                cathed = true;
            }
            Assert.IsTrue(cathed);
        }
    }
    [TestClass]
    public class RegularTest
    {
        Regular r = new Regular();
        [TestMethod]
        public void IsEmailTest1()
        {
            string line = "test@test.test";
            Assert.IsTrue(r.Email(line));
        }
        [TestMethod]
        public void IsEmailTest2()
        {
            string line = "test@testtest";
            Assert.IsFalse(r.Email(line));
        }
    }
    [TestClass]
    public class NumberTest
    {
        string str;
        Number a = new Number();
        [TestMethod]
        public void SumTest1()
        {
            str = "123";
            int actual = a.Sum(str);
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumTest2()
        {
            bool cathed = false;
            try
            {
                str = "afs";
                int actual = a.Sum(str);
            }
            catch (ArgumentException)
            {
                cathed = true;
            }

            Assert.IsTrue(cathed);
        }
        [TestMethod]
        public void SumTest3()
        {
            bool cathed = false;
            try
            {
                str = "-1";
                int actual = a.Sum(str);
            }
            catch (ArgumentException)
            {
                cathed = true;
            }

            Assert.IsTrue(cathed);
        }
    }
}
