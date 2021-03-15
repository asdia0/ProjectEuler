namespace ProjectEuler
{
    using System;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=47">Project Euler: Problem 47</see>
        /// </summary>
        /// <returns>134043</returns>
        public static int Problem47()
        {
            int i = 1;

            while (true)
            {
                if (PrimeFactors(i).Count != 4 || PrimeFactors(i-1).Count != 4 || PrimeFactors(i-2).Count != 4 || PrimeFactors(i-3).Count != 4)
                {
                    i++;
                }
                else
                {
                    return i-3;
                }
            }
        }
    }
}

