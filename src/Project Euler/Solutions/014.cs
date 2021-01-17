namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=14">Project Euler: Problem 14</see>
        /// </summary>
        /// <returns>837799</returns>
        public static long Problem14()
        {
            long result = 0;
            long startingnum = 0;

            for (int i = 1; i <= 1000000; i++)
            {
                List<long> chain = GetCollatzChain(i);
                if (chain.Count > result)
                {
                    result = chain.Count;
                    startingnum = i;
                }
            }

            return startingnum;
        }

        /// <summary>
        /// Gets the Collatz chain of n.
        /// </summary>
        /// <param name="n">The given number.</param>
        /// <returns>A Collatz chain.</returns>
        public static List<long> GetCollatzChain(long n)
        {
            List<long> result = new List<long>();

            if (n == 1)
            {
                return result;
            }
            else if (n <= 0)
            {
                throw new Exception();
            }
            else
            {
                while (n != 1)
                {
                    if (n % 2 == 0)
                    {
                        result.Add(n);
                        n = n / 2;
                    }
                    else
                    {
                        result.Add(n);
                        n = (3 * n) + 1;
                    }
                }

                return result;
            }
        }
    }
}
