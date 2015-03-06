using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2_3;

namespace Task2_3Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RootTest1()
        {
            var a = MathMethods.Root(81, 4);
            Assert.AreEqual(a, 3);
        }
        [TestMethod]
        public void RootTest2()
        {
            double accuracy = 0.001;
            var a = MathMethods.Root(81, 4, accuracy);
            Assert.AreEqual(a, 3, accuracy);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RootTest3()
        {
            var a = MathMethods.Root(-2, 4);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RootTest4()
        {
            var a = MathMethods.Root(2, -4);
        }
        [TestMethod]
        public void EuclideanAlgoTest1()
        {
            var a = MathMethods.EuclideanAlgo(12, 36, 44);
            Assert.AreEqual(a, 4);
        }
        [TestMethod]
        public void EuclideanAlgoTest2()
        {
            var a = MathMethods.EuclideanAlgo(12, 3);
            Assert.AreEqual(a, 3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EuclideanAlgoTest3()
        {
            var a = MathMethods.EuclideanAlgo(12);
            Assert.AreEqual(a, 3);
        }
        [TestMethod]
        public void BinaryEuclideanAlgoTest1()
        {
            var a = MathMethods.BinaryEuclideanAlgo(12, 36, 44);
            Assert.AreEqual(a, 4);
        }
        [TestMethod]
        public void BinaryEuclideanAlgoTest2()
        {
            var a = MathMethods.BinaryEuclideanAlgo(12, 3);
            Assert.AreEqual(a, 3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BinaryEuclideanAlgoTest3()
        {
            var a = MathMethods.BinaryEuclideanAlgo(12);
            Assert.AreEqual(a, 3);
        }
    }
}
