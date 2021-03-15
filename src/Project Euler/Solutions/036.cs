namespace ProjectEuler
{
    using System;
    using System.Numerics;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=36">Project Euler: Problem 36</see>
        /// </summary>
        /// <returns>872187</returns>
        public static long Problem36()
        {
            long sum = 0;

            for (int i = 1; i < 1000000; i++)
            {
                if (IsPalindrome(i))
                {
                    if (IsPalindrome(BigInteger.Parse(Convert.ToString(i, 2))))
                    {
                        sum += i;
                    }
                }
            }

            return sum;
        }
    }
}
