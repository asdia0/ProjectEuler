namespace ProjectEuler
{
    using System;

    public partial class Solutions
    {
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
    }
}
