namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=24">Project Euler: Problem 24</see>
        /// </summary>
        /// <returns>2783915460</returns>
        public static long Problem24()
        {
            int nthPosition = 1000000, n = 10;

            long res = 0;

            BigInteger currentIndex = 0;

            List<int> digits = new List<int>()
            {
                0,
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
            };

            while (n > 0)
            {
                int iterations = 0;

                while (currentIndex < nthPosition)
                {
                    iterations++;
                    currentIndex += Factorial(n - 1);
                }

                res = (res * 10) + digits[iterations-1];
                digits.RemoveAt(iterations-1);
                currentIndex -= Factorial(n - 1);

                n--;
            }

            return res;
        }
    }
}
