namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=39">Project Euler: Problem 39</see>
        /// </summary>
        /// <returns>840</returns>
        public static int Problem39()
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 1; i <= 1000; i++)
            {
                d.Add(i, 0);
            }

            for (int a = 1; a < 998; a++)
            {
                for (int b = 1; b < 999 - a; b++)
                {
                    double c = Math.Sqrt(a * a + b * b);

                    if (c % 1 != 0)
                    {
                        continue;
                    }

                    if (a + b + c <= 1000)
                    {
                        d[a + b + (int)c]++;
                    }
                }
            }

            return d.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        }
    }
}
