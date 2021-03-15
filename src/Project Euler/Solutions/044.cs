namespace ProjectEuler
{
    using System;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=44">Project Euler: Problem 44</see>
        /// </summary>
        /// <returns>5482660</returns>
        public static long Problem44()
        {
            int k = 0;

            while (true)
            {
                k++;

                for (int j = 1; j < k; j++)
                {
                    long pentJ = GetPentagonalNumber(k);
                    long pentK = GetPentagonalNumber(j);

                    if (IsPentagonal(Math.Abs(pentJ - pentK)))
                    {
                        if (IsPentagonal(pentJ + pentK))
                        {
                            return Math.Abs(pentJ - pentK);
                        }
                    }
                }
            }
        }
    }
}
