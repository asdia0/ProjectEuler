namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=31">Project Euler: Problem 31</see>
        /// </summary>
        /// <returns>73682</returns>
        public static int Problem31()
        {
            int counter = 1;

            for (int pence1 = 0; pence1 <= 200; pence1++)
            {
                for (int pence2 = 0; pence2 <= 100; pence2++)
                {
                    for (int pence5 = 0; pence5 <= 40; pence5++)
                    {
                        for (int pence10 = 0; pence10 <= 20; pence10++)
                        {
                            for (int pence20 = 0; pence20 <= 10; pence20++)
                            {
                                for (int pence50 = 0; pence50 <= 4; pence50++)
                                {
                                    for (int pound1 = 0; pound1 <= 2; pound1++)
                                    {
                                        if (pence1 + pence2 * 2 + pence5 * 5 + pence10 * 10 + pence20 * 20 + pence50 * 50 + pound1 * 100 == 200)
                                        {
                                            counter++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return counter;
        }
    }
}
