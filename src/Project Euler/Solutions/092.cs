namespace ProjectEuler
{
    using System;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=92">Project Euler: Problem 92</see>
        /// </summary>
        /// <returns>Answer</returns>
        public static long Problem92()
        {
            long count = 0;

            for (int n = 1; n <= 10000000; n++)
            {
                if (_092_Sum(n) == 89)
                {
                    count++;
                }
            }

            return count;
        }

        public static long _092_Sum(long n)
        {
            int sum = 0;

            foreach (int digit in GetDigits(n))
            {
                sum += digit * digit;
            }

            if (sum == 1 || sum == 89)
            {
                return sum;
            }

            return _092_Sum(sum);
        }
    }
}