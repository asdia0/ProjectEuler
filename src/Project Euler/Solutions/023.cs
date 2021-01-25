namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=23">Project Euler: Problem 23</see>
        /// </summary>
        /// <returns>4179871</returns>
        public static long Problem23()
        {
            long sum = 0;

            HashSet<int> abunList = new HashSet<int>();
            HashSet<int> sumList = new HashSet<int>();

            for (int i = 1; i <= 28123; i++)
            {
                var factors = new HashSet<int>()
                {
                    1,
                };

                for (int factor = 2; factor <= (int)Math.Sqrt(i); factor++)
                {
                    if (i % factor == 0)
                    {
                        factors.Add(factor);
                        if (factor != i / factor)
                        {
                            factors.Add(i / factor);
                        }
                    }
                }

                if (factors.Sum() > i)
                {
                    abunList.Add(i);
                }
            }

            foreach (int abun1 in abunList)
            {
                foreach (int abun2 in abunList)
                {
                    if (abun1 + abun2 <= 28123)
                    {
                        sumList.Add(abun1 + abun2);
                    }
                }
            }

            for (int i = 1; i <= 28123; i++)
            {
                if (!sumList.Contains(i))
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
