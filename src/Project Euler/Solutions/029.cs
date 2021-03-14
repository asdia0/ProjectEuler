namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=29">Project Euler: Problem 29</see>
        /// </summary>
        /// <returns>9183</returns>
        public static long Problem29()
        {
            HashSet<BigInteger> l = new HashSet<BigInteger>();

            for (int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    l.Add(BigInteger.Pow(a, b));
                }
            }

            return l.Count;
        }
    }
}
