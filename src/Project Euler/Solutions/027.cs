namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=27">Project Euler: Problem 27</see>
        /// </summary>
        /// <returns>-59231</returns>
        public static long Problem27()
        {
            Dictionary<(int, int), int> d = new Dictionary<(int, int), int>();

            for (int a = -999; a < 1000; a++)
            {
                for (int b = 0; b <= 1000; b++)
                {
                    if (!IsPrime(b))
                    {
                        continue;
                    }

                    int n = 0;

                    while (IsPrime(Math.Abs((n * n) + (a * n) + b)))
                    {
                        n++;
                    }

                    d.Add((a, b), n);
                }
            }

            (int aSol, int bSol) = d.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            return aSol * bSol;
        }
    }
}
