namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=37">Project Euler: Problem 37</see>
        /// </summary>
        /// <returns>748317</returns>
        public static long Problem37()
        {
            int counter = 0;
            long n = 13;
            long sum = 0;

            while (counter < 11)
            {
                if (IsRightTruncPrime(n) && IsLeftTruncPrime(n))
                {
                    counter++;
                    sum += n;
                }
                n += 2;
            }

            return sum;
        }
    }
}
