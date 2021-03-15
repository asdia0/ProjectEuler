namespace ProjectEuler
{
    using System;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=45">Project Euler: Problem 45</see>
        /// </summary>
        /// <returns>1533776805</returns>
        public static long Problem45()
        {
            int n = 165;

            while (true)
            {
                n++;

                long pent = GetPentagonalNumber(n);

                if (IsHexagonal(pent))
                {
                    return pent;
                }
            }
        }
    }
}
