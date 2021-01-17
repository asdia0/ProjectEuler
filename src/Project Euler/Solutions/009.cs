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
            List<(long, long, long)> triples = GetPythogoreanTriple(1000);
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
