namespace ProjectEuler
{
    using System;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=53">Project Euler: Problem 53</see>
        /// </summary>
        /// <returns>4075</returns>
        public static long Problem53()
        {
            long counter = 0;

            for (int n = 1; n <= 100; n++)
            {
                for (int r = 1; r <= n; r++)
                {
                    if (Choose(n, r) > 1000000)
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }
    }
}
