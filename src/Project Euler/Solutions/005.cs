namespace ProjectEuler
{
    using System;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=5">Project Euler: Problem 5</see>
        /// </summary>
        /// <returns>232792560</returns>
        public static long Problem5()
        {
            long inc = 2;
            long step = 2;
            long smallestNum = 2;

            while (smallestNum <= long.MaxValue)
            {
                for (int i = 2; i <= 20; i++)
                {
                    if (smallestNum % i != 0)
                    {
                        break;
                    }

                    if (i == inc)
                    {
                        step = smallestNum;
                        inc++;
                    }

                    if (i == 20)
                    {
                        return smallestNum;
                    }
                }

                smallestNum += step;
            }

            throw new Exception();
        }
    }
}
