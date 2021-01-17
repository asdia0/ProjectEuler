namespace ProjectEuler
{
    using System.Collections.Generic;

    public partial class Solutions
    {
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
    }
}
