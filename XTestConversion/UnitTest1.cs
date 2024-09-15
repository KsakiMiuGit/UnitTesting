using UnitTesting;

namespace XTestConversion
{
    public class UnitTest1
    {
        private readonly CurrencyConverter converter;

        public UnitTest1()
        {
            converter = new CurrencyConverter();
        }

        [Fact]
        public void TestPLNToEuro()
        {
            decimal PLN = 100;
            decimal ExpectedEuro = 420;
            decimal result = converter.PLNToEuro(PLN);
            Assert.Equal(ExpectedEuro, result);
        }

        [Fact]
        public void TestPLNToUsd()
        {
            decimal PLN = 100;
            decimal ExpectedUsd = 450;
            decimal result = converter.PLNToUsd(PLN);
            Assert.Equal(ExpectedUsd, result);
        }

        [Fact]
        public void TestPLNToGbp()
        {
            decimal PLN = 100;
            decimal ExpectedGbp = 500;
            decimal result = converter.PLNToGbp(PLN);
            Assert.Equal(ExpectedGbp, result);
        }

        [Fact]
        public void TestPLNToJpy()
        {
            decimal PLN = 100;
            decimal ExpectedJpy = 3;
            decimal result = converter.PLNToJpy(PLN);
            Assert.Equal(ExpectedJpy, result);
        }
    }
}