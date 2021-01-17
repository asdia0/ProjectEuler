namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;

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
    }
}
