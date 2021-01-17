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

            List<long> fibb = new List<long>();
            long num = 0;
            long prev = 1;
            long prev1 = 0;

            while (num < 4000000)
            {
                num = prev + prev1;
                fibb.Add(num);
                prev = prev1;
                prev1 = num;
            }

            foreach (long fibnum in fibb)
            {
                if (fibnum % 2 == 0)
                {
                    sum += fibnum;
                }
            }

            return sum;
        }
    }
}
