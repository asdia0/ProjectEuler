namespace ProjectEuler
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=3">Project Euler: Problem 3</see>
        /// </summary>
        /// <returns>6857</returns>
        public static long Problem3()
        {
            List<long> pfactors = GetPrimeFactors(600851475143);

            return pfactors.Last();
        }
    }
}
