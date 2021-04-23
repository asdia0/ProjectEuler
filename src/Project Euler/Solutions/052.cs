namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=52">Project Euler: Problem 52</see>
        /// </summary>
        /// <returns>142857</returns>
        public static long Problem52()
        {
            int i = 0;
            while (true)
            {
                i++;

                List<int> originalDigits = GetDigits(i);

                int counter = 0;

                for (int multiplier = 2; multiplier <= 7; multiplier++)
                {
                    if (Enumerable.SequenceEqual(originalDigits.OrderBy(e => e), GetDigits(multiplier * i).OrderBy(e => e)))
                    {
                        counter++;
                    }
                }

                if (counter == 5)
                {
                    return i;
                }
            }
        }
    }
}
