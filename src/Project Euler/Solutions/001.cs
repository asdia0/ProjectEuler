namespace ProjectEuler
{
    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=1">Project Euler: Problem 1</see>
        /// </summary>
        /// <returns>233168</returns>
        public static long Problem1()
        {
            long sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
