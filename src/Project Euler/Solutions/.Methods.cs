namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Linq;

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
        public static bool IsPalindrome(BigInteger n)
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

        public static List<int> GetDigits(long n)
        {
            List<int> res = new List<int>();
            foreach (char c in n.ToString())
            {
                res.Add(int.Parse(c.ToString()));
            }
            return res;
        }

        public static bool IsPandigital(long n)
        {
            List<int> digits = GetDigits(n);

            if (digits.Distinct().Count() == digits.Count)
            {
                List<int> range = new List<int>();

                for (int i = 1; i <= digits.Distinct().Count(); i++)
                {
                    if (!digits.Contains(i))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public static bool IsPandigitalZero(long n)
        {
            List<int> digits = GetDigits(n);

            if (digits.Distinct().Count() == digits.Count)
            {
                List<int> range = new List<int>();

                for (int i = 0; i <= digits.Distinct().Count(); i++)
                {
                    if (!digits.Contains(i))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }


        public static long GCD(long a, long b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

        public static long[]? CircularNumbers(long n)
        {
            long[] res = new long[GetDigits(n).Count()];

            res[0] = n;

            for (int i = 1; i < res.Length; i++)
            {
                if (res[i - 1] < 10)
                {
                    return null;
                }

                int digit = int.Parse(res[i - 1].ToString()[0].ToString());

                long result = 10 * (res[i - 1] - (digit * (long)Math.Pow(10, res.Length - 1))) + digit;

                if (result < 0)
                {
                    return null;
                }

                res[i] = result;
            }

            return res;
        }

        public static long? AddDigitRight(long n, int digit)
        {
            if (digit < 0 || digit > 10)
            {
                return null;
            }

            return (n * 10) + digit;
        }

        public static long? AddDigitLeft(long n, int digit)
        {
            if (digit < 0 || digit > 10)
            {
                return null;
            }

            return n + digit * (long)Math.Pow(10, GetDigits(n).Count);
        }

        public static long RemoveLeftDigit(long n)
        {
            return long.Parse(n.ToString().Remove(0, 1));
        }

        public static long RemoveRightDigit(long n)
        {
            return long.Parse(n.ToString().Remove(n.ToString().Count() - 1));
        }

        public static bool IsRightTruncPrime(long n)
        {
            while (IsPrime(n))
            {
                n = RemoveRightDigit(n);

                if (n.ToString().Count() == 1)
                {
                    if (IsPrime(n))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool IsLeftTruncPrime(long n)
        {
            while (IsPrime(n))
            {
                n = RemoveLeftDigit(n);

                if (n.ToString().Count() == 1)
                {
                    if (IsPrime(n))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool IsTriangular(long n)
        {
            if (n < 0)
            {
                return false;
            }

            int sum = 0;
            for (int i = 1; sum <= n; i++)
            {
                sum = sum + i;
                if (sum == n)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool HasDistinctDigits(long n)
        {
            if (GetDigits(n).Distinct().Count() == GetDigits(n).Count())
            {
                return true;
            }

            return false;
        }

        public static long MakePandigital(long n)
        {
            List<int> digits = GetDigits(n).Distinct().ToList();
            long origN = n;

            string newN = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                if (!digits.Contains(i))
                {
                    newN = $"{i}{origN}";
                }
            }

            return long.Parse(newN);
        }

        public static bool IsPentagonal(long n)
        {
            int i = 1, M;

            do
            { 
                M = (3 * i * i - i) / 2;
                i += 1;
            }
            while (M < n);

            return (M == n);
        }

        public static long GetPentagonalNumber(long n)
        {
            return ((3 * n * n) - n) / 2;
        }

        public static bool IsHexagonal(long n)
        {
            long val = 8 * n + 1;

            double x = 1 + Math.Sqrt(val);

            double y = x / 4;

            if ((y - (int)y) == 0)
            {
                return true;
            }

            return false;
        }

        public static long GetTriangularNumber(long n)
        {
            return ((n * n) + n) / 2;
        }

        public static long GetHexagonalNumber(long n)
        {
            return (2 * n * n) - n;
        }

        public static List<long> GeneratePrimes(long n)
        {
            List<long> res = new List<long>();

            for (long i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    res.Add(i);
                }
            }

            return res;
        }

        public static List<int> PrimeFactors(int number)
        {
            var primes = new List<int>();

            for (int div = 2; div <= number; div++)
            {
                while (number % div == 0)
                {
                    primes.Add(div);
                    number = number / div;
                }
            }

            return primes.Distinct().ToList();
        }
    }
}