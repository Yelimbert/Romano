using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace decToRomTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = decToRom.Program.decimal_to_roman(100);
            Assert.AreEqual("C", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string result = decToRom.Program.decimal_to_roman(400);
            Assert.AreEqual("CD", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string result = decToRom.Program.decimal_to_roman(753);
            Assert.AreEqual("DCCLIII", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string result = decToRom.Program.decimal_to_roman(1003);
            Assert.AreEqual("MIII", result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string result = decToRom.Program.decimal_to_roman(1999);
            Assert.AreEqual("MCMXCIX", result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string result = decToRom.Program.decimal_to_roman(2002);
            Assert.AreEqual("MMII", result);
        }
    }
}
