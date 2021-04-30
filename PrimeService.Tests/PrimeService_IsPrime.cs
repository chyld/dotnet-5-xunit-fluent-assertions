using Xunit;
using Prime.Services;
using FluentAssertions;

namespace Prime.Services.Tests
{
    public class PrimeService_IsPrime
    {
        [Fact]
        public void IsPrime_InputIs3_ReturnTrue()
        {
            // Arrange
            var primeService = new PrimeService();

            // Act
            bool result = primeService.IsPrime(3);

            // Assert
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            // Arrange
            var primeService = new PrimeService();

            // Act
            var result = primeService.IsPrime(value);

            // Assert
            result.Should().BeFalse($"{value} should not be prime");
        }
    }
}
