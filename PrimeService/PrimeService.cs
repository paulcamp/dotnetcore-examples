using System;

namespace Prime.Services
{
    public class PrimeService
    {
       public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public List<int> GeneratePrimes(int n) {
            var r = from i in Enumerable.Range(2, n - 1)
            where Enumerable.Range(1, (int)Math.Sqrt(i)).All(j => j == 1 || i % j != 0)
                select i;
            return r.ToList();
        }

          public List<int> GeneratePrimesInParallel(int n) {
            var r = from i in Enumerable.Range(2, n - 1).AsParallel()
            where Enumerable.Range(1, (int)Math.Sqrt(i)).All(j => j == 1 || i % j != 0)
                select i;
            return r.ToList();
        }
    }
}