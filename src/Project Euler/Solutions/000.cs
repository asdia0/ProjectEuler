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

        /// <summary>
        /// Generates a n-long list of primes.
        /// </summary>
        /// <param name="n">The number of primes to generate.</param>
        /// <returns>A list of primes.</returns>
        public static List<long> GetPrimes(long n)
        {
            List<long> result = new List<long>();

            long i = 2;

            while (result.Count < n)
            {
                if (IsPrime(i))
                {
                    result.Add(i);
                }

                i++;
            }

            return result;
        }

        /// <summary>
        /// Generates a list of prime numbers that are less than n.
        /// </summary>
        /// <param name="n">The maximum value of the largest prime number in the list.</param>
        /// <returns>A list of prime numbers.</returns>
        public static List<long> GetPrimesLessThan(long n)
        {
            List<long> result = new List<long>();

            for (int i = 0; i < n; i++)
            {
                if (IsPrime(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }

        /// <summary>
        /// Generates a list of Fibbonanci numbers that are less than n.
        /// </summary>
        /// <param name="n">The maximum value of the largest Fibbonanci number in the list.</param>
        /// <returns>A list of Fibbonanci numbers.</returns>
        public static List<long> GetFibbNumsLessThan(long n)
        {
            List<long> result = new List<long>();
            long fibb = 0;
            long prev = 1;
            long prev1 = 0;

            while (fibb < n)
            {
                fibb = prev + prev1;
                result.Add(fibb);
                prev = prev1;
                prev1 = fibb;
            }

            return result;
        }

        /// <summary>
        /// Gets the smallest positive integer that is evenly divisible by all number from 1 to n.
        /// </summary>
        /// <param name="n">The largest number that the integer canbe divided by.</param>
        /// <returns>A positive integer.</returns>
        public static long GetSmallestDiv(long n)
        {
            long inc = 2;
            long step = 2;
            long smallestNum = 2;

            while (smallestNum <= long.MaxValue)
            {
                for (int i = 2; i <= n; i++)
                {
                    if (smallestNum % i != 0)
                    {
                        break;
                    }

                    if (i == inc)
                    {
                        step = smallestNum;
                        inc++;
                    }

                    if (i == n)
                    {
                        return smallestNum;
                    }
                }

                smallestNum += step;
            }

            throw new Exception("Problem 5: This shouldn't be happening. Please check your code again");
        }

        /// <summary>
        /// Gets the prime factors of n.
        /// </summary>
        /// <param name="n">The given number.</param>
        /// <returns>A list of prime factors.</returns>
        public static List<long> GetPrimeFactors(long n)
        {
            List<long> result = new List<long>();

            for (long i = 1; i <= n; i++)
            {
                if (n % i == 0 && IsPrime(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }

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
        /// Gets all Pythogorean triples where c is less than n.
        /// </summary>
        /// <param name="n">THe maximum value of c</param>
        /// <returns>A list of Pythogorean triples in (a, b, c) format</returns>
        public static List<(long, long, long)> GetPythogoreanTriple(long n)
        {
            int a, b, c = 0;

            int m = 2;

            List<(long, long, long)> result = new List<(long, long, long)>();

            while (c < n)
            {
                for (int o = 1; o < m; o++)
                {
                    a = (m * m) - (o * o);
                    b = 2 * m * o;
                    c = (m * m) + (o * o);

                    if (c > n)
                    {
                        break;
                    }

                    result.Add((a, b, c));
                }

                m++;
            }

            return result;
        }
    }
}
