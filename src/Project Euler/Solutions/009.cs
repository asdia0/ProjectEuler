namespace ProjectEuler
{
    using System.Collections.Generic;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=9">Project Euler: Problem 9</see>
        /// </summary>
        /// <returns>31875000</returns>
        public static long Problem9()
        {
            int a, b, c = 0;

            int m = 2;

            List<(long, long, long)> triples = new List<(long, long, long)>();

            while (c < 1000)
            {
                for (int o = 1; o < m; o++)
                {
                    a = (m * m) - (o * o);
                    b = 2 * m * o;
                    c = (m * m) + (o * o);

                    if (c > 1000)
                    {
                        break;
                    }

                    triples.Add((a, b, c));
                }

                m++;
            }

            long result = 0;

            foreach ((long, long, long) elem in triples)
            {
                if (elem.Item1 + elem.Item2 + elem.Item3 == 1000)
                {
                    result = elem.Item1 * elem.Item2 * elem.Item3;
                }
            }

            return result;
        }
    }
}
