namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=21">Project Euler: Problem 21</see>
        /// </summary>
        /// <returns>31626</returns>
        public static long Problem21()
        {
            long result = 0;

            Dictionary<long, long> sumD = new Dictionary<long, long>();

            for (int n = 2; n < 10000; n++)
            {
                int sqrtOfNumber = (int)Math.Sqrt(n);
                int sum = 1;

                if (n == sqrtOfNumber * sqrtOfNumber)
                {
                    sum += sqrtOfNumber;
                    sqrtOfNumber--;
                }

                for (int i = 2; i <= sqrtOfNumber; i++)
                {
                    if (n % i == 0)
                    {
                        sum = sum + i + (n / i);
                    }
                }

                sumD.Add(n, sum);
            }

            for (long i = 2; i < 10000; i++)
            {
                if (sumD[i] > i && sumD[i] < 10000)
                {
                    if (sumD[sumD[i]] == i)
                    {
                        result += i + sumD[i];
                    }
                }
            }

            return result;
        }
    }
}
