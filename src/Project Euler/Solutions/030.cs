namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=30">Project Euler: Problem 30</see>
        /// </summary>
        /// <returns>443839</returns>
        public static long Problem30()
        {
            int res = 0;

            for (int i = 2; i <= 354294; i++)
            {
                long sum = 0;

                foreach (int digit in GetDigits(i))
                {
                    sum += (long)Math.Pow(digit, 5);
                }

                if (sum == i)
                {
                    res += i;
                }
            }

            return res;
        }
    }
}
