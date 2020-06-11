using NUnit.Framework;

namespace CheckEx.Tests
{
    [TestFixture]
    class CheckExTests
    {
        [Test]
        [TestCase("", false)]
        [TestCase("1000", true)]
        [TestCase("-1000", true)]
        [TestCase("1,000.00", true)]
        [TestCase("-1,000.00", true)]
        [TestCase("1,000.00e12", true)]
        [TestCase("1,000.00e+12", true)]
        [TestCase("1,000.00e-12", true)]
        [TestCase("1,0000.00", false)]
        [TestCase("1,0,0", false)]
        [TestCase("1,0.0", false)]
        public void IsNumber_WhenGivenInputString_ShouldReturnExpectedValue(string input, bool expected)
        {
            var sut = new CheckEx();

            var actual = sut.IsNumber(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
