namespace ProjectEuler
{
    using System.Linq;
    using System.Collections.Generic;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=26">Project Euler: Problem 26</see>
        /// </summary>
        /// <returns>983</returns>
        public static long Problem26()
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int d = 2; d <= 1000; d++)
            {
                int[] seenRemainders = new int[d];

                int remainder = 1;
                int index = 0;

                while (seenRemainders[remainder] == 0 && remainder != 0)
                {
                    seenRemainders[remainder] = index;

                    remainder = (10 * remainder) % d;
                    index++;
                }

                dic.Add(d, index - seenRemainders[remainder]);
            }

            return dic.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        }
    }
}

