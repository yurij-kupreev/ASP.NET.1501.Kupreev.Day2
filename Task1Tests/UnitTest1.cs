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
            var a = String.Format(new BinaryFormatter(), "{0} (binary: {0:B}) (hex: {0:H})", 123324);
            Assert.AreEqual("123324 (binary: 11110000110111100) (hex: 1E1BC)", a);
            
        }
        [TestMethod]
        public void ConvertTest2()
        {
            var a = String.Format(new BinaryFormatter(), "{0} (binary: {0:B}) (hex: {0:H})", 9);
            Assert.AreEqual("9 (binary: 1001) (hex: 9)", a);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertTest3()
        {
            var a = String.Format(new BinaryFormatter(), "{0} (binary: {0:B}) (hex: {0:H})", "somestring");
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ConvertTest4()
        {
            var a = String.Format(new BinaryFormatter(), "{0} (binary: {0K:B}) (hex: {0KK:H})", 123324);
        }
    }
}
