namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Newtonsoft.Json;

    /// <summary>
    /// Main class of the project.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point for the project.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Which problem would you like to check?");
            int problem = int.Parse(Console.ReadLine());
            Type type = typeof(Program);
            MethodInfo method = type.GetMethod($"Problem{problem}");
            Program c = new Program();
            var result = method.Invoke(c, null);
            Console.WriteLine($"\nProblem {problem}: {JsonConvert.SerializeObject(result)}\n\n");
        }

        // Problems
        #region

        /// <summary>
        /// <see href="https://projecteuler.net/problem=1">Project Euler: Problem 1</see>
        /// </summary>
        /// <returns>233168</returns>
        public static long Problem1()
        {
            long sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        /// <summary>
        /// <see href="https://projecteuler.net/problem=2">Project Euler: Problem 2</see>
        /// </summary>
        /// <returns>4613732</returns>
        public static long Problem2()
        {
            long sum = 0;

            List<long> fibb = GetFibbNumsLessThan(4000000);

            foreach (long num in fibb)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }

            return sum;
        }

        /// <summary>
        /// <see href="https://projecteuler.net/problem=3">Project Euler: Problem 3</see>
        /// </summary>
        /// <returns>6857</returns>
        public static long Problem3()
        {
            List<long> pfactors = GetPrimeFactors(600851475143);

            return pfactors.Last();
        }

        /// <summary>
        /// <see href="https://projecteuler.net/problem=4">Project Euler: Problem 4</see>
        /// </summary>
        /// <returns>906609</returns>
        public static long Problem4()
        {
            List<long> results = new List<long>();

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    if (IsPalindrome(i * j))
                    {
                        results.Add(i * j);
                    }
                }
            }

            results.Sort();

            return results.Last();
        }

        /// <summary>
        /// <see href="https://projecteuler.net/problem=5">Project Euler: Problem 5</see>
        /// </summary>
        /// <returns>232792560</returns>
        public static long Problem5()
        {
            return GetSmallestDiv(20);
        }

        /// <summary>
        /// <see href="https://projecteuler.net/problem=6">Project Euler: Problem 6</see>
        /// </summary>
        /// <returns>25164150</returns>
        public static long Problem6()
        {
            long sqSum = 0;
            long sumOf100 = 0;

            for (int i = 1; i <= 100; i++)
            {
                sqSum += (long)Math.Pow(i, 2);
                sumOf100 += i;
            }

            long sqSum100 = (long)Math.Pow(sumOf100, 2);

            return sqSum100 - sqSum;
        }

        /// <summary>
        /// <see href="https://projecteuler.net/problem=7">Project Euler: Problem 7</see>
        /// </summary>
        /// <returns>104743</returns>
        public static long Problem7()
        {
            return GetPrimes(10001).Last();
        }

        /// <summary>
        /// <see href="https://projecteuler.net/problem=8">Project Euler: Problem 8</see>
        /// </summary>
        /// <returns>23514624000</returns>
        public static long Problem8()
        {
            string snum = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";

            List<short> numl = new List<short>();
            List<long> resultList = new List<long>();

            foreach (char c in snum)
            {
                numl.Add(short.Parse(c.ToString()));
            }

            for (int i = 0; i < numl.Count; i++)
            {
                try
                {
                    List<short> cList = new List<short>
                    {
                        numl[i],
                        numl[i + 1],
                        numl[i + 2],
                        numl[i + 3],
                        numl[i + 4],
                        numl[i + 5],
                        numl[i + 6],
                        numl[i + 7],
                        numl[i + 8],
                        numl[i + 9],
                        numl[i + 10],
                        numl[i + 11],
                        numl[i + 12],
                    };

                    long product = 1;

                    foreach (short n in cList)
                    {
                        product *= n;
                    }

                    resultList.Add(product);
                }
                catch
                {
                }
            }

            resultList.Sort();
            return resultList.Last();
        }

        /// <summary>
        /// <see href="https://projecteuler.net/problem=9">Project Euler: Problem 9</see>
        /// </summary>
        /// <returns>31875000</returns>
        public static long Problem9()
        {
            List<(long, long, long)> triples = GetPythogoreanTriple(1000);
            long result = 0;
            foreach ((long, long, long) elem in triples)
            {
                if (elem.Item1 + elem.Item2 + elem.Item3 == 1000)
                {
                    result = elem.Item1 * elem.Item2 * elem.Item3;
                }
            }

            return result;
        }

        /// <summary>
        /// <see href="https://projecteuler.net/problem=10">Project Euler: Problem 10</see>
        /// </summary>
        /// <returns>142913828922</returns>
        public static long Problem10()
        {
            long sum = 0;
            List<long> primes = GetPrimesLessThan(2000000);
            foreach (long prime in primes)
            {
                sum += prime;
            }

            return sum;
        }

        #endregion

        // Other methods
        #region

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
        /// Gets all Pythogorean triples where c < n.
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
        #endregion
    }
}
