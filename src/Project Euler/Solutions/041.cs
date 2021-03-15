namespace ProjectEuler
{
    using System;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=41">Project Euler: Problem 41</see>
        /// </summary>
        /// <returns>7652413</returns>
        public static long Problem41()
        {
            for (int i = 7654321; i > 0; i--)
            {
                if (IsPandigital(i) && IsPrime(i))
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
