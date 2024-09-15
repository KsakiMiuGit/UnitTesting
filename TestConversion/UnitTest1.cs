using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;

namespace TestConversion
{

    [TestClass]
    public class UnitTest1
    {

        private CurrencyConverter? converter; 

        [TestInitialize]
        public void Setup()
        {
            converter = new CurrencyConverter(); 
        }

        [TestMethod]
        public void TestPLNToEuro()
        {
            decimal PLN = 100;
            decimal ExpectedEuro = 420;
            decimal result = converter.PLNToEuro(PLN);
            Assert.AreEqual(ExpectedEuro, result);
        }

        [TestMethod]
        public void TestPLNToUsd()
        {
            decimal PLN = 100;
            decimal ExpectedUsd = 450;
            decimal result = converter.PLNToUsd(PLN);
            Assert.AreEqual(ExpectedUsd, result);
        }

        [TestMethod]
        public void TestPLNToGbp()
        {
            decimal PLN = 100;
            decimal ExpectedGbp = 500;
            decimal result = converter.PLNToGbp(PLN);
            Assert.AreEqual(ExpectedGbp, result);
        }

        [TestMethod]
        public void TestPLNToJpy()
        {
            decimal PLN = 100;
            decimal ExpectedJpy = 3;
            decimal result = converter.PLNToJpy(PLN);
            Assert.AreEqual(ExpectedJpy, result);
        }
    }
}