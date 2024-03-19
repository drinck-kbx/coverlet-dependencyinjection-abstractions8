using MissingCoverage.Host;
using Xunit;
using Xunit.Categories;

namespace MissingCoverage.Tests
{
    [UnitTest]
    public class CalculatorTests
    {
        private readonly Calculator _sut = new();

        [Fact]
        public void Add_Validumbers_ValidResult()
        {
            var result = _sut.Add(2, 5);

            Assert.Equal(7, result);
        }
    }
}
