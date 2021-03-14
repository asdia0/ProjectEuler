namespace ProjectEuler
{
    using System.Collections.Generic;
    using System.Linq;
    using System;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=35">Project Euler: Problem 35</see>
        /// </summary>
        /// <returns>55</returns>
        public static int Problem35()
        {
            List<long> res = new List<long>()
            {
                2,
                3,
                5,
                7,
            };

            for (int i = 10; i < 1000000; i++)
            {
                if (!IsPrime(i))
                {
                    continue;
                }

                int minicounter = 0;

                long[]? circlularNumbers = CircularNumbers(i);

                if (circlularNumbers == null)
                {
                    continue;
                }

                foreach (long num in circlularNumbers)
                {
                    if (!IsPrime(num))
                    {
                        break;
                    }

                    minicounter++;
                }

                if (minicounter == GetDigits(i).Count)
                {
                    res.AddRange(circlularNumbers.ToList());
                }
            }

            res = res.Distinct().ToList();

            return res.Count;
        }
    }
}
