namespace ProjectEuler
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=33">Project Euler: Problem 33</see>
        /// </summary>
        /// <returns>100</returns>
        public static long Problem33()
        {
            int aProduct = 1;
            int bProduct = 1;

            for (int i = 1; i < 10; i++)
            {
                for (int a = 1; a < i; a++)
                {
                    for (int b = 1; b < a; b++)
                    {
                        if ((b * 10 + i) * a == b * (i * 10 + a))
                        {
                            aProduct *= a;
                            bProduct *= b;
                        }
                    }
                }
            }

            return aProduct / GCD(aProduct, bProduct);
        }
    }
}
