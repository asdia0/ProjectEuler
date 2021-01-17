namespace ProjectEuler
{
    using System.Collections.Generic;
    using System.Numerics;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=16">Project Euler: Problem 16</see>
        /// </summary>
        /// <returns>1366</returns>
        public static long Problem16()
        {
            string snum = BigInteger.Pow(2, 1000).ToString();
            long sum = 0;

            foreach (char c in snum)
            {
                sum += long.Parse(c.ToString());
            }

            return sum;
        }
    }
}
