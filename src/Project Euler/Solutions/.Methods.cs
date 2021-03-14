namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    /// <summary>
    /// Class containing all the solutions of the Project Euler problems.
    /// </summary>
    public partial class Solutions
    {
        /// <summary>
        /// Checks if n is a prime.
        /// </summary>
        /// <param name="n">The given number.</param>
        /// <returns>True if n is a prime.</returns>
        public static bool IsPrime(long n)
        {
            if (n == 1 || n == 0)
            {
                return false;
            }

            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks if n is a palindrome.
        /// </summary>
        /// <param name="n">The given number.</param>
        /// <returns>True if n is a palindrome.</returns>
        public static bool IsPalindrome(long n)
        {
            string snum = n.ToString();

            for (int i = 0; i < Math.Floor((decimal)snum.Length / 2); i++)
            {
                if (snum[i] != snum[snum.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Gets the factorial of n.
        /// </summary>
        /// <param name="n">The given number.</param>
        /// <returns>The factorial of n.</returns>
        public static BigInteger Factorial(long n)
        {
            if (n < 0)
            {
                throw new Exception("Number must be positive.");
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public static BigInteger TriangleNumber(long n)
        {
            BigInteger sum = 0;

            for (long i = 1; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }

        public static List<int> GetDigits(long n)
        {
            List<int> res = new List<int>();
            foreach (char c in n.ToString())
            {
                res.Add(int.Parse(c.ToString()));
            }
            return res;
        }
    }
}