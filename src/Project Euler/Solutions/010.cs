namespace ProjectEuler
{
    using System.Collections.Generic;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=10">Project Euler: Problem 10</see>
        /// </summary>
        /// <returns>142913828922</returns>
        public static long Problem10()
        {
            long sum = 0;
            List<long> primes = GetPrimesLessThan(2000000);
            foreach (long prime in primes)
            {
                sum += prime;
            }

            return sum;
        }
    }
}
