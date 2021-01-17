namespace ProjectEuler
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=7">Project Euler: Problem 7</see>
        /// </summary>
        /// <returns>104743</returns>
        public static long Problem7()
        {
            List<long> result = new List<long>();

            long i = 2;

            while (result.Count < 10001)
            {
                if (IsPrime(i))
                {
                    result.Add(i);
                }

                i++;
            }

            return result.Last();
        }
    }
}
