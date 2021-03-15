namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=46">Project Euler: Problem 46</see>
        /// </summary>
        /// <returns>5777</returns>
        public static long Problem46()
        {
            long n = 1;

            while (true)
            {
                n += 2;

                if (IsPrime(n))
                {
                    continue;
                }

                int counter = 0;

                List<long> primeList = GeneratePrimes(n);

                foreach (long prime in primeList)
                {
                    if (Math.Sqrt((double)decimal.Divide(n - prime, 2)) % 1 == 0)
                    {
                        break;
                    }
                    else
                    {
                        counter++;
                    }
                }

                if (counter == primeList.Count)
                {
                    return n;
                }
            }
        }
    }
}
