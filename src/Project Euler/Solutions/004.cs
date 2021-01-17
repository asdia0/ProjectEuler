namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=4">Project Euler: Problem 4</see>
        /// </summary>
        /// <returns>906609</returns>
        public static long Problem4()
        {
            List<long> results = new List<long>();

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    if (IsPalindrome(i * j))
                    {
                        results.Add(i * j);
                    }
                }
            }

            results.Sort();

            return results.Last();
        }
    }
}
