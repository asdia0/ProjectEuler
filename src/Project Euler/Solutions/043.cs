namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=43">Project Euler: Problem 43</see>
        /// </summary>
        /// <returns>16695334890</returns>
        public static long Problem43()
        {
            long sum = 0;

            for (int f17 = 17; f17 < 1000; f17 += 17)
            {
                if (!HasDistinctDigits(f17))
                {
                    continue;
                }

                for (int f13 = 13; f13 < 1000; f13 += 13)
                {
                    if (!HasDistinctDigits(f13) || f17 / 10 != f13 % 100)
                    {
                        continue;
                    }

                    for (int f11 = 11; f11 < 1000; f11 += 11)
                    {
                        if (!HasDistinctDigits(f11) || f13 / 10 != f11 % 100)
                        {
                            continue;
                        }

                        for (int f7 = 7; f7 < 1000; f7 += 7)
                        {
                            if (!HasDistinctDigits(f7) || f11 / 10 != f7 % 100)
                            {
                                continue;
                            }

                            for (int f5 = 5; f5 < 1000; f5 += 5)
                            {
                                if (!HasDistinctDigits(f5) || f7 / 10 != f5 % 100)
                                {
                                    continue;
                                }

                                for (int f3 = 3; f3 < 1000; f3 += 3)
                                {
                                    if (!HasDistinctDigits(f3) || f5 / 10 != f3 % 100)
                                    {
                                        continue;
                                    }

                                    for (int f2 = 2; f2 < 1000; f2 += 2)
                                    {
                                        if (!HasDistinctDigits(f2) || f3 / 10 != f2 % 100)
                                        {
                                            continue;
                                        }

                                        long n = long.Parse($"{f2}{f3 % 10}{f5 % 10}{f7 % 10}{f11 % 10}{f13 % 10}{f17 % 10}");

                                        if (!HasDistinctDigits(n))
                                        {
                                            continue;
                                        }

                                        long pan = MakePandigital(n);

                                        if (n == pan || GetDigits(pan).Count != 10)
                                        {
                                            continue;
                                        }

                                        sum += pan;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return sum;
        }
    }
}
