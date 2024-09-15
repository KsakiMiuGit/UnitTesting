using UnitTesting;

namespace NTestConversion
{
    public class Tests
    {
        private CurrencyConverter converter;
        [SetUp]
        public void Setup()
        {
            converter = new CurrencyConverter();
        }

        [Test]
        public void TestPLNToEuro()
        {
            decimal PLN = 100;
            decimal ExpectedEuro = 420;
            decimal result = converter.PLNToEuro(PLN);
            Assert.That(result, Is.EqualTo(ExpectedEuro));
        }

        [Test]
        public void TestPLNToUsd()
        {
            decimal PLN = 100;
            decimal ExpectedUsd = 450;
            decimal result = converter.PLNToUsd(PLN);
            Assert.That(result, Is.EqualTo(ExpectedUsd));
        }

        [Test]
        public void TestPLNToGbp()
        {
            decimal PLN = 100;
            decimal ExpectedGbp = 500;
            decimal result = converter.PLNToGbp(PLN);
            Assert.That(result, Is.EqualTo(ExpectedGbp));
        }

        [Test]
        public void TestPLNToJpy()
        {
            decimal PLN = 100;
            decimal ExpectedJpy = 3;
            decimal result = converter.PLNToJpy(PLN);
            Assert.That(result, Is.EqualTo(ExpectedJpy));
        }

    }
}