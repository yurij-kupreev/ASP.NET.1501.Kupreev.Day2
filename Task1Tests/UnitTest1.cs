using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace Task1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConvertTest1()
        {
            var a = CustomFormatProvider.Convert(17434565, 16);
            Assert.AreEqual(a, "10A07C5");
        }
        [TestMethod]
        public void ConvertTest2()
        {
            var a = CustomFormatProvider.Convert(9, 16);
            Assert.AreEqual(a, "9");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertTest3()
        {
            var a = CustomFormatProvider.Convert(-2, 16);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertTest4()
        {
            var a = CustomFormatProvider.Convert(2, -16);
        }
    }
}
