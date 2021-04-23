namespace ProjectEuler
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=51">Project Euler: Problem 51</see>
        /// </summary>
        /// <returns>121313</returns>
        public static long Problem51()
        {
            List<long> primes = GeneratePrimes(1000000);

            for (int i = 0; i < primes.Count; i++)
            {
                long prime = primes[i];

                foreach (int digit in GetDigits(prime))
                {
                    List<long> generatedprimes = new List<long>();

                    for (int replacedDigit = 0; replacedDigit < 10; replacedDigit++)
                    {
                        long newprime = int.Parse(prime.ToString().Replace(digit.ToString(), replacedDigit.ToString()));

                        if (GetDigits(newprime).Count != GetDigits(prime).Count)
                        {
                            continue;
                        }

                        if (IsPrime(newprime))
                        {
                            generatedprimes.Add(newprime);
                        }
                    }

                    if (generatedprimes.Count == 8)
                    {
                        return prime;
                    }
                }
            }

            return 0;
        }
    }
}
