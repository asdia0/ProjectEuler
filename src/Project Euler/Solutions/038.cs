namespace ProjectEuler
{
    using System;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=38">Project Euler: Problem 38</see>
        /// </summary>
        /// <returns>932718654</returns>
        public static long Problem38()
        {
            for (long x = 9999; x > 0; x--)
            {
                Console.WriteLine(x);

                int n = 1;

                string s = string.Empty;

                while (s.Length < 9)
                {
                    s += $"{x * n}";
                    n++;
                }

                if (n == 1)
                {
                    continue;
                }

                if (s.Length == 9)
                {
                    if (IsPandigital(long.Parse(s)))
                    {
                        return long.Parse(s);
                    }
                }
            }

            return 0;
        }
    }
}
