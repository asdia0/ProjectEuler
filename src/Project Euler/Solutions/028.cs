namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=28">Project Euler: Problem 28</see>
        /// </summary>
        /// <returns>Answer</returns>
        public static long Problem28()
        {
            int side = (1001 - 1) / 2;

            int[] d = new int[side + 1];

            d[0] = 1;

            for (int i = 1; i <= side; i++)
            {
                d[i] = (4 * (int)Math.Pow((2 * i) + 1, 2)) - (12 * i) + d[i - 1];
            }

            return d[side];
        }
    }
}
