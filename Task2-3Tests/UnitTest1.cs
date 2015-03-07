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
            Assert.AreEqual(3, a);
        }
        [TestMethod]
        public void RootTest2()
        {
            double accuracy = 0.001;
            var a = MathMethods.Root(81, 4, accuracy);
            Assert.AreEqual(3, a, accuracy);
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
            var a = MathMethods.EuclideanAlgorithm(12, 36, 44);
            Assert.IsTrue(a > 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EuclideanAlgoTest2()
        {
            var a = MathMethods.EuclideanAlgorithm(12);
        }
        [TestMethod]
        public void BinaryEuclideanAlgoTest1()
        {
            var a = MathMethods.BinaryEuclideanAlgorithm(12, 36, 44);
            Assert.IsTrue(a > 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BinaryEuclideanAlgoTest2()
        {
            var a = MathMethods.BinaryEuclideanAlgorithm(12);
        }
    }
}
