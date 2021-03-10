namespace ProjectEuler
{
    using System;
    using System.Numerics;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=25">Project Euler: Problem 25</see>
        /// </summary>
        /// <returns>4782</returns>
        public static long Problem25()
        {
            int numberOfDigits = 1000, index = 1;
            BigInteger a = 0, b = 1, c = 0;

            while (IntLength(c) < numberOfDigits)
            {
                index++;
                c = a + b;
                a = b;
                b = c;
            }

            return index;
        }

        public static int IntLength(BigInteger i)
        {
            if (i < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (i == 0)
            {
                return 1;
            }
            {
                return (int)Math.Floor(BigInteger.Log10(i)) + 1;
            }
        }
    }
}
