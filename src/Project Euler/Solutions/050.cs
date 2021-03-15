namespace ProjectEuler
{
    using System;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=50">Project Euler: Problem 50</see>
        /// </summary>
        /// <returns>997651</returns>
        public static long Problem50()
        {
            long res = 0;

            long[] primes = GeneratePrimes(1000000).ToArray();

            long[] sumPrimes = new long[primes.Length];

            sumPrimes[0] = 2;

            for (int i = 1; i < primes.Length; i++)
            {
                sumPrimes[i] = sumPrimes[i - 1] + primes[i];
            }

            int primeNo = 0;

            for (int i = primeNo; i < primes.Length; i++)
            {
                for (int j = i - primeNo - 1; j >= 0; j--)
                {
                    if (sumPrimes[i] - sumPrimes[j] > 1000000)
                    {
                        break;
                    }

                    if (Array.IndexOf(primes, sumPrimes[i] - sumPrimes[j]) >= 0)
                    {
                        primeNo = i - j;
                        res = sumPrimes[i] - sumPrimes[j];
                    }
                }
            }

            return res;
        }
    }
}
