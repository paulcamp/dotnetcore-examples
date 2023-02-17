
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_GeneratePrimesInParallelShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_GeneratePrimesInParallelShould()
        {
            _primeService = new PrimeService();
        }


        [Fact]
        public void GeneratePrimesInParallel_PrimesUpto10AreCorrect()
        {
            var result = _primeService.GeneratePrimesInParallel(10);
     
            Assert.Contains(2, result);
            Assert.Contains(3, result);
            Assert.Contains(5, result);
            Assert.Contains(7, result);
        }
    }
}