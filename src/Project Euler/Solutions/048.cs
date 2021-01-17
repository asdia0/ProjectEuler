namespace ProjectEuler
{
    using System.Numerics;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=48">Project Euler: Problem 48</see>
        /// </summary>
        /// <returns>9110846700</returns>
        public static BigInteger Problem48()
        {
            BigInteger sum = 0;

            for (int i = 1; i < 1001; i++)
            {
                sum += BigInteger.Pow(i, i);
            }

            return BigInteger.Parse(sum.ToString()[^10..]);
        }
    }
}
