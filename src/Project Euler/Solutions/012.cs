namespace ProjectEuler
{
    using System;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=12">Project Euler: Problem 12</see>
        /// </summary>
        /// <returns>76576500</returns>
        public static long Problem12()
        {
            int number = 0;
            int i = 1;

            while (GetNumberOfFactors(number) < 500)
            {
                number += i;
                i++;
            }

            return number;
        }

        /// <summary>
        /// Gets the number of factors of n.
        /// </summary>
        /// <param name="n">The given number.</param>
        /// <returns>The number of factors of n</returns>
        public static long GetNumberOfFactors(long n)
        {
            long nod = 0;
            long sqrt = (long)Math.Sqrt(n);

            for (int i = 1; i <= sqrt; i++)
            {
                if (n % i == 0)
                {
                    nod += 2;
                }
            }

            if (sqrt * sqrt == n)
            {
                nod--;
            }

            return nod;
        }
    }
}
