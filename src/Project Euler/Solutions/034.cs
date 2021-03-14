namespace ProjectEuler
{
    using System;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=34">Project Euler: Problem 34</see>
        /// </summary>
        /// <returns>40730</returns>
        public static long Problem34()
        {
            long sum = 0;

            for (int i = 10; i < 999999; i++)
            {
                long factSum = 0;

                foreach (int digit in GetDigits(i))
                {
                    factSum += (long)Factorial(digit);
                }

                if (factSum == i)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
