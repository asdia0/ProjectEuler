namespace ProjectEuler
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=49">Project Euler: Problem 49</see>
        /// </summary>
        /// <returns>296962999629</returns>
        public static long Problem49()
        {
            List<long> primes = GeneratePrimes(10000);

            foreach (long prime in primes.ToList())
            {
                if (prime < 1489)
                {
                    primes.Remove(prime);
                }
            }

            primes.Remove(4817);
            primes.Remove(8147);

            foreach (long prime in primes)
            {
                List<long> permutations = GetPermutations(prime).Distinct().ToList();

                long p1 = prime + 3330;
                long p2 = prime + 6660;

                if (permutations.Contains(p1) && IsPrime(p1) && permutations.Contains(p2) && IsPrime(p2))
                {
                    List<long> l = new List<long>()
                    {
                        p1,
                        p2,
                    };

                    l.Sort();

                    string s = prime.ToString();

                    foreach (long e in l)
                    {
                        s += e.ToString();
                    }

                    return long.Parse(s);
                }
            }

            return 0;
        }
    }
}
