
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_GeneratePrimesShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_GeneratePrimesShould()
        {
            _primeService = new PrimeService();
        }


        [Theory]
        [InlineData(10, "2,3,5,7")]
        [InlineData(20, "2,3,5,7,11,13,17,19")]
        public void GeneratePrimes_PrimesAreCorrect(int range, string expected )
        {
            var result = _primeService.GeneratePrimes(range);
            var actual = string.Join(",", result);

            Assert.Equal(expected, actual);
        }
    }
}