namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=19">Project Euler: Problem 19</see>
        /// </summary>
        /// <returns>171</returns>
        public static long Problem19()
        {
            long counter = 0;

            for (int year = 1901; year <= 2000; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    if (new DateTime(year, month, 1).DayOfWeek == DayOfWeek.Sunday)
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }
    }
}
